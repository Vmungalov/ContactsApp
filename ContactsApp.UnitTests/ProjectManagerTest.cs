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
        }
        
        [Test(Description = "Тест на успешную загрузку файла с проектом"), Order(1), NonParallelizable]
        public async Task SuccessfulLoadingTest()
        {
            _status = await ProjectManager.LoadProjectAsync();
            Assert.AreEqual(_status.Status, LoadingStatus.Success, "Не удалось загрузить проект.");
        }

        [Test(Description = "Попытка загрузить испорченный файл"), Order(2), NonParallelizable]
        public void LoadingCorruptedFileTest()
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
            await ProjectManager.SaveProjectAsync(_project);
            var loadStatus = await ProjectManager.LoadProjectAsync();
            Assert.AreEqual(_project.ContactList, loadStatus.Project.ContactList, "Проект сохранился с искажениями.");
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