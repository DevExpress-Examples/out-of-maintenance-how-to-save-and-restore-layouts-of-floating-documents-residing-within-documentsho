using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication2 {
    public class MyUserSettings : ApplicationSettingsBase {
        [UserScopedSetting()]
        public BindingList<Host> Hosts {
            get {
                return ((BindingList<Host>)this["Hosts"]);
            }
            set { this["Hosts"] = value; }
        }
        //[UserScopedSetting()]
        //public BindingList<Rectangle> HostPositions {
        //    get { return ((BindingList<Rectangle>)this["HostPositions"]); }
        //    set { this["HostPositions"] = value; }
        //}
    }

    public class Host {
        public Host() {
        }

        public string HostID {
            get;
            set;
        }
        public Rectangle HostBounds {
            get;
            set;
        }
        public FormWindowState FormState {
            get;
            set;
        }
    }
}