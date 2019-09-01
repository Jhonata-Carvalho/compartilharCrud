using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class ClsGrud
    {
        static List<ClsGrud> listaLG = new List<ClsGrud>();
        static int MaxId = 0;

        protected int _Id;
        protected string _Cliente;
        protected string _Pedido;
        protected int _Quantidade;
        protected float _Preco;
        protected float _Total;

        #region Construtores
        public ClsGrud()
        {
            _Id = 0;
            _Cliente = "";
            _Pedido = "";
            _Quantidade = 0;
            _Preco = 0;
            _Total = 0;
        }
        public ClsGrud(string cliente, string pedido, int quantde, float preco, float total)
        {
            _Cliente = cliente;
            _Pedido = pedido;
            _Quantidade = quantde;
            _Preco = preco;
            _Total = total;
        }
        public ClsGrud(int id, string cliente, string pedido, int quantde, float preco, float total)
        {
            _Id = id;
            _Cliente = cliente;
            _Pedido = pedido;
            _Quantidade = quantde;
            _Preco = preco;
            _Total = total;
        }
        public ClsGrud(int id)
        {
           ClsGrud aux = listaLG.Find(lc => lc.ID == id);
            _Id = aux.ID;
            _Cliente = aux.CLIENTE;
            _Pedido = aux.PEDIDO;
            _Quantidade = aux.QUANTIDADE;
            _Preco = aux.PREÇO;
            _Total = aux.TOTAL;
        }
        #endregion

        #region Propriedade
        public int ID
        {
            set { _Id = value;}
            get { return _Id;}
        }
        public string CLIENTE
        {
            set { _Cliente = value; }
            get { return _Cliente; }
        }
        public string PEDIDO
        {
            set { _Pedido = value; }
            get { return _Pedido; }
        }
        public int QUANTIDADE
        {
            set { _Quantidade = value; }
            get { return _Quantidade; }
        }
        public float PREÇO
        {
            set { _Preco = value; }
            get { return _Preco; }
        }
        public float TOTAL
        {
            set { _Total = value; }
            get { return _Total; }
        }
        #endregion

        #region Acessa dados
        public void Inserir()
        {
            MaxId++;
            _Id = MaxId;
            listaLG.Add(this);
        }
        public static List<ClsGrud> Consultar()
        {
            return listaLG;
        }
        public static List<ClsGrud> Consultar(string cliente)
        {
            return listaLG.FindAll(ltg => ltg.CLIENTE.Contains(cliente));
        }
        public void Alterar()
        {
            int i;
            i = listaLG.FindIndex(lg => lg.ID == _Id);
            listaLG[i].CLIENTE = _Cliente;
            listaLG[i].PEDIDO = _Pedido;
            listaLG[i].QUANTIDADE = _Quantidade;
            listaLG[i].PREÇO = _Preco;
            listaLG[i].TOTAL = _Total;
        }
        public void Excluir()
        { }
        #endregion
    }
}
