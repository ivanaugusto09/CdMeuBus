using CadeMeuBus.Helper;
using CadeMeuBus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CadeMeuBus.ViewModel
{
    public class MapPageViewModel 
    {

        public PageStatusEnum PageStatusEnum { get; set; }

        public ICommand ChangePageStatusCommand { get; set; }
       
        public ObservableCollection<itinerario> Itinerario { get; set; }
       

        public MapPageViewModel()
        {    
            Horarios();
        }

        void Horarios()
        {
            Itinerario = new ObservableCollection<itinerario>()
            {
                {new itinerario(){ Linha="Linha 1", Saida="Terminal -> Alto da Glória", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

            {new itinerario(){ Linha="Linha 2", Saida="Terminal -> Boa Esperança", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }
                    

            } } },


            {new itinerario(){ Linha="Linha 3", Saida="Terminal -> Camping Club", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },


            {new itinerario(){ Linha="Linha 4", Saida="Terminal -> Comunidada Atântica", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },


            {new itinerario(){ Linha="Linha 5", Saida="Terminal -> Maria Vandilina", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

           {new itinerario(){ Linha="Linha 6", Saida="Terminal -> Maria Vandilina/Via Campo Verde", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

             {new itinerario(){ Linha="Linha 8", Saida="Terminal -> Bom Jardim", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

             {new itinerario(){ Linha="Linha 11", Saida="Terminal -> Gente Feliz", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

             {new itinerario(){ Linha="Linha 12", Saida="Terminal -> UFMT", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

             {new itinerario(){ Linha="Linha 19", Saida="Terminal -> JHONROB", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } },

            {new itinerario(){ Linha="Linha 20", Saida="Terminal -> Daury Riva", Detalhes=new System.Collections.Generic.List<Detalhes>(){
                    {new Detalhes(){ Tipo="Ônibus Rosa", Preco="3.60", Info="Ônibus com Acessibilidade", Icon="bus.png"} }


            } } } };
        
        }
    }

}



    




