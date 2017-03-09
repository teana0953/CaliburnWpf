using Caliburn.Micro;
using System;
using System.ComponentModel.Composition;
using System.Windows;

namespace BasicConfig {

    public class ShellViewModel : PropertyChangedBase, IShell
    {
        public BindableCollection<Model> Items { get; private set; }

        public ShellViewModel()
        {
            Items = new BindableCollection<Model>
            {
                new Model { Id=Guid.NewGuid() },
                new Model { Id=Guid.NewGuid() },
                new Model { Id=Guid.NewGuid() },
                new Model { Id=Guid.NewGuid() }
            };
        }

        public void Add()
        {
            Items.Add(new Model { Id=Guid.NewGuid() });
        }

        public void Remove(Model child)
        {
            Items.Remove(child);
        }
    }
}