using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System;
namespace blazor.Pages
{
    public class Apps
    {
        private int _number;
        public int Number
        {
            get 
            {
                return _number;
            }
            set
            {
                if(Number != value)
                {
                    _number=value;
                    NotifyDataChanged ();
                }
            }
        }
        private string _color;
        public string Color
        {
            get 
            {
                return _color;
            }
            set{
                _color=value;
                NotifyDataChanged();
            }
        }
        public event Action OnChange;
        private void NotifyDataChanged()=>OnChange?.Invoke();
    }
}