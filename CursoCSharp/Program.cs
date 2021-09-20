using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoAObjeto;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos",Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Interferencia - Fundamentos",Inferencia.Executar},
                {"Interpolacao - Fundamentos",Interpolacao.Executar},
                {"LendoDados - Fundamentos",LendoDados.Executar},
                {"NotacaoPonto - Fundamentos",NotacaoPonto.Executar},
                {"Formatando Numeros - Fundamentos",FormatandoNumero.Executar},
                {"Conversões - Fundamentos",Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Operadores relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores logicos - Fundamentos",OperadoresLogicos.Executar},
                {"Operadores de atribuicao - Fundamentos",OperadoresDeAtribuicao.Executar},
                {"Operadores unários - Fundamentos",OperadoresUnarios.Executar},
                {"Operadores tenários - Fundamentos",OperadoresTenarios.Executar},
                
                //Estruturas de controle
                {"Estrutura IF - Estruturas de controle",EstruturaIF.Executar},
                {"Estrutura IF/ELSE - Estruturas de controle",EstruturaIFELSE.Executar},
                {"Estrutura IF/ELSE IF - Estruturas de controle",EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle",EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle",EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controle",EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle",EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controle",EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controle",UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle",UsandoContinue.Executar},

                //Clases e metódos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com retornos - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parâmetros nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Props.Executar},
                {"Atributos Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", Readonly.Executar},
                {"Structs - Classes e Metodos", ExemploStructs.Executar},
                {"Structs vs Classes - Classes e Metodos", StructVsClasse.Executar},
                {"Valor vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros Por referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro padrão - Classes e Metodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", ColecoesArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Colecoes - Coleções", ColecoesStack.Executar},
                {"Dictonary - Coleções", ColecoesDictonary.Executar},

                //Orientação a objetos
                {"Herança - Orientação a objeto", Herenca.Executar},
                {"Construtor this - Orientação a objeto", ConstrutorThis.Executar},
                {"Class abstrata - Orientação a objeto", ClassAbstrata.Executar},
                {"Interface - Orientação a objeto", Interface.Executar},
                {"Sealed - Orientação a objeto", Sealed.Executar},
                {"Encapsulamento - Orientação a objeto", EncapsulamentoOO.Executar},

                //Metodos e funções
                {"Exemplo lambda - metodos e funções", ExemploLambda.Executar},
                {"Lambdas delegate - metodos e funções", LambdasDelegate.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}