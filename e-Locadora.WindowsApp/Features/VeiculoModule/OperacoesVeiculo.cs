﻿using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio.VeiculosModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.VeiculoModule
{
    public class OperacoesVeiculo : ICadastravel
    {
        private ControladorVeiculos controladorVeiculo = null;
        private ControladorGrupoVeiculo controladorGrupoVeiculo = null;
        private TabelaVeiculoControl tabelaVeiculoControl = null;



        public OperacoesVeiculo(ControladorVeiculos ctrlVeiculo)
        {
            controladorVeiculo = ctrlVeiculo;
            tabelaVeiculoControl = new TabelaVeiculoControl();
        }


        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            //int id = tabelaVeiculoControl.ObtemIdSelecionado();

            //if (id == 0)
            //{
            //    MessageBox.Show("Selecione um Veiculo para poder editar!", "Edição de Veiculos",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //Veiculo VeiculoSelecionada = controladorVeiculo.SelecionarPorId(id);

            //TelaVeiculoForm tela = new TelaVeiculoForm();

            //tela.Veiculo = VeiculoSelecionada;

            //if (tela.ShowDialog() == DialogResult.OK)
            //{
            //    controladorVeiculo.Editar(id, tela.Veiculo);

            //    tabelaVeiculoControl.AtualizarRegistros();

            //    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.placa}] editado com sucesso");
            //}
        }

        public void ExcluirRegistro()
        {
            //int id = tabelaVeiculoControl.ObtemIdSelecionado();

            //if (id == 0)
            //{
            //    MessageBox.Show("Selecione um veiculo para poder excluir!", "Exclusão de Veiculo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //Veiculo VeiculoSelecionada = controladorVeiculo.SelecionarPorId(id);

            //if (MessageBox.Show($"Tem certeza que deseja excluir o veiculo: [{VeiculoSelecionada.Placa}] ?",
            //    "Exclusão de Veiculo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
            //    controladorVeiculo.Excluir(id);

            //    tabelaVeiculoControl.AtualizarRegistros();

            //    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{VeiculoSelecionada.Placa}] removido com sucesso");
            //}
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            //TelaVeiculoForm tela = new TelaVeiculoForm();

            //if (tela.ShowDialog() == DialogResult.OK)
            //{
            //    controladorVeiculo.InserirNovo(tela.Veiculo);

            //    List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

            //    tabelaVeiculoControl.AtualizarRegistros(veiculos);

            //    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo}] inserido com sucesso");
            //}
        }

        public UserControl ObterTabela()
        {
            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

            tabelaVeiculoControl.AtualizarRegistros(veiculos);

            return tabelaVeiculoControl;
        }
    }
}