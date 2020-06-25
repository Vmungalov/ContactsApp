using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp;
using ContactsApp.Exceptions;
using ContactsApp.Settings;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _project;
        private ProjectStatus _status;
        private string _bak = Paths.MainFilePath + ".testbak";
        private string _contactBak = Paths.OneContactBackupFilePath + ".testbak";

        [SetUp]
        public void InitProjectManager()
        {
            _project = new Project();
            _status = new ProjectStatus();
            Directory.CreateDirectory(Paths.AppFolder);
            if (File.Exists(Paths.MainFilePath))
            {
                File.Delete(_bak);
                File.Copy(Paths.MainFilePath, _bak);
            }
            else
            {
                File.Create(Paths.MainFilePath);
                File.Copy(Paths.MainFilePath, _bak);
            }
            if (File.Exists(Paths.OneContactBackupFilePath))
            {
                File.Delete(_contactBak);
                File.Copy(Paths.OneContactBackupFilePath, _contactBak);
            }
        }

        [TearDown]
        public void DeleteTestBackup()
        {
            
            if (File.Exists(_bak))
            {
                File.Delete(Paths.MainFilePath);
                File.Move(_bak, Paths.MainFilePath );
                File.Delete(_bak);
            }

            if (File.Exists(_contactBak))
            {
                File.Delete(Paths.OneContactBackupFilePath);
                File.Move(_contactBak, Paths.OneContactBackupFilePath);
                File.Delete(_contactBak);
            }
        }
        
        [Test(Description = "Тест на успешную загрузку файла с проектом"), Order(1), NonParallelizable]
        public async Task SuccessfulLoadingTest()
        {
            _status = await ProjectManager.LoadProjectAsync();
            Assert.AreEqual(_status.Status, LoadingStatus.Success, "Не удалось загрузить проект.");
        }

        [Test(Description = "Попытка загрузить испорченный файл"), Order(2), NonParallelizable]
        public async Task LoadingCorruptedFileTest()
        {
            Assert.ThrowsAsync<ProjectFileCorruptedException>(async () =>
            {
                FileStream stream = File.Open(Paths.MainFilePath, FileMode.OpenOrCreate);
                var array = System.Text.Encoding.UTF8.GetBytes("Some trash");
                stream.Seek(0, SeekOrigin.End);
                await stream.WriteAsync(array, 0, array.Length);
                stream.Close();
                _status = await ProjectManager.LoadProjectAsync();
            });
        }

        [Test(Description = "Попытка сохранить и загрузить проект"), Order(3), NonParallelizable]
        public async Task SuccessfulSavingTest()
        {
            await ProjectManager.SaveProjectAsync(_project, false);
            var loadStatus = await ProjectManager.LoadProjectAsync();
            Assert.AreEqual(_project.ContactList, loadStatus.Project.ContactList, "Проект сохранился с искажениями.");
        }

        [Test(Description = "Попытка записать и прочитать бэкап контакта"), Order(4), NonParallelizable]
        public async Task SuccessfulBackupTest()
        {
            var contact = new Contact()
            {
                Birthday = DateTime.Today,
                Email = "v_mungalov@mail.ru",
                Number = new PhoneNumber(),
                Surname = "Surname",
                FirstName = "First Name",
                IdVk = "id0"
            };
            contact.Number.SetNumber("+71234567890");
            ContactBackup backup = new ContactBackup()
            {
                Contact = contact,
                Index = 0
            };
            await ProjectManager.BackupContactAsync(backup);
            FileStream stream = File.Open(Paths.OneContactBackupFilePath, FileMode.OpenOrCreate);
            var bytes = new byte[stream.Length];
            await stream.ReadAsync(bytes, 0, bytes.Length);
            string readString = System.Text.Encoding.UTF8.GetString(bytes);
            stream.Close();
            var readBackup = JsonConvert.DeserializeObject<ContactBackup>(readString);
            Assert.True(backup.Equals(readBackup), "Контакт бэкапится с искажениями");
        }
        
        [Test(Description = "Попытка пересоздать проект"), Order(5), NonParallelizable]
        public async Task SuccessfulOverCreatingTest()
        {
            var test = new Project();
            await ProjectManager.RecreateProjectAsync();
            var loadStatus = await ProjectManager.LoadProjectAsync();
            Assert.AreEqual(test.ContactList, loadStatus.Project.ContactList, "Проект сохранился с искажениями.");
        }
    }
}