//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zachet4.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Predmet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Predmet()
        {
            this.Ocenka = new HashSet<Ocenka>();
        }
    
        public int id { get; set; }
        public string PredmetName { get; set; }
        public Nullable<int> IDTeacher { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocenka> Ocenka { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
