using System.Windows.Forms;

namespace ContactsAppUI.Models
{
    // TODO: вместо создания класса можно было использовать кортежи Tuple
    public class DialogReturn<T>
    {
        public T Value { get; set; }
        public DialogResult Result { get; set; }
    }
}