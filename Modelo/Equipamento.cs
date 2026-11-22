using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    public class Equipamento
    {
        public string marca;
        public string modelo;
        public string sala;
        public int ano_aquisicao;
        public decimal preco_compra;

        public Equipamento(string _marca, string _modelo, string _sala, int _ano_aquisicao, decimal _preco_compra)
        {
            marca = _marca;
            modelo = _modelo;
            sala = _sala;
            ano_aquisicao = _ano_aquisicao;
            preco_compra = _preco_compra;
        }
        public string ObterDescricao()
        {
            return $"Marca: {marca}\n" +
                $"Modelo: {modelo}\n" +
                $"Sala: {sala}\n" +
                $"Ano de aquisição: {ano_aquisicao}\n" +
                $"Preço de compra: {preco_compra}";
        }
        public string MostrarDado(int numero)
        {
            string r = "";
            if (numero == 1) { r = marca; }
            else if (numero == 2) { r = modelo; }
            else if (numero == 4) { r = sala; }
            else if (numero == 5) { r = $"{ano_aquisicao}"; }
            else if (numero == 6) { r = $"{preco_compra}"; }

            return r;

        }
    }
}
