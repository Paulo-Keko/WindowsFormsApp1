using System.Data.Linq.Mapping;


namespace WindowsFormsApp1.Classe
{
    [Table(Name = "aliquotasInss")]
    public class aliquotasInss
    {

        private decimal _aliquota;
        [Column(Storage = "_aliquota")]
        public decimal aliquota
        {
            get
            {
                return this._aliquota;
            }
            set
            {
                this._aliquota = value;
            }
        }

        private int _ano;
        [Column(Storage = "_ano")]
        public int ano
        {
            get
            {
                return this._ano;
            }
            set
            {
                this._ano = value;
            }
        }

        private decimal _salario_inf;
        [Column(Storage = "_salario_inf")]
        public decimal salario_inf
        {
            get
            {
                return this._salario_inf;
            }
            set
            {
                this._salario_inf = value;
            }
        }

        private decimal _salario_sup;
        [Column(Storage = "_salario_sup")]
        public decimal salario_sup
        {
            get
            {
                return this._salario_sup;
            }
            set
            {
                this._salario_sup = value;
            }
        }
    }
}
