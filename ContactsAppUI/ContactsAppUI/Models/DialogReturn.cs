using System.Windows.Forms;

namespace ContactsAppUI.Models
{
    public class DialogReturn<T>
    {
        public T Value { get; set; }
        public DialogResult Result { get; set; }
    }
}