//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebCpfCnpj
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.Venda = new HashSet<Venda>();
        }
    
        public int id { get; set; }
        public string descricao { get; set; }
        public Nullable<System.DateTime> dataEntrada { get; set; }
        public Nullable<int> tipo { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<int> fornecedor { get; set; }
    
        public virtual Fornecedor Fornecedor1 { get; set; }
        public virtual Tipo Tipo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}