using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using MahApps.UI.Views;

namespace MahApps.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private HamburgerMenuItemCollection _menuItems;
        private HamburgerMenuItemCollection _menuOptionItems;

        public MainViewModel()
        {
        }

        public HamburgerMenuItemCollection MenuItems
        {
            get { return _menuItems; }
            set
            {
                if (Equals(value, _menuItems)) return;
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        public HamburgerMenuItemCollection MenuOptionItems
        {
            get { return _menuOptionItems; }
            set
            {
                if (Equals(value, _menuOptionItems)) return;
                _menuOptionItems = value;
                OnPropertyChanged();
            }
        }

        public void CreateMenuItems()
        {
            MenuItems = new HamburgerMenuItemCollection();
            MenuOptionItems = new HamburgerMenuItemCollection();

            this.MenuItems.Add(
                new HamburgerMenuIconItem()
                {
                    Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.Home },
                    Label = "Home",
                    ToolTip = "ToolTip",
                    Tag = new HomeView()
                }
            );
            this.MenuItems.Add(
                new HamburgerMenuIconItem()
                {
                    Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.Home },
                    Label = "Item_1",
                    ToolTip = "ToolTip",
                    Tag = new HomeView()
                }
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
