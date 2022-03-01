using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCompiladoresI_ISCUAA
{
    public partial class rich : Component
    {
        public rich()
        {
            InitializeComponent();
        }

        public rich(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
