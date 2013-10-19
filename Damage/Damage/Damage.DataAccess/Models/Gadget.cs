using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Damage.DataAccess.Models {
    
    public class Gadget {
        public Gadget() {
			UserGadgets = new List<UserGadget>();
        }
        public virtual int GadgetId { get; set; }
        [Required()]
        public virtual string GadgetName { get; set; }
        [Required()]
        public virtual string GadgetVersion { get; set; }
        public virtual IList<UserGadget> UserGadgets { get; set; }
    }
}
