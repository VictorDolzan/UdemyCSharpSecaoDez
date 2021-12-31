using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioConta;
using CSharpSecaoDez.ExercicioConta.Entities;
using CSharpSecaoDez.ExercicioResolvido;
using CSharpSecaoDez.ExercicioResolvido.EntitiesR;
using CSharpSecaoDez.ExercicioFixacao;
using CSharpSecaoDez.ExercicioFixacao.EntitiesF;
using CSharpSecaoDez.ExercicioResolvidoDois;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD.EnumsRD;

namespace  CSharpSecaoDez
{
    class Program
    {
        public static void Main(string[] args)
        {
          //ExercicioConta.ExercicioConta.ExecutarExercicioConta();
          //ExercicioResolvido.ExercicioResolvido.ExecutarExercicioResolvido();
          //ExercicioFixacao.ExercicioFixacao.ExecutarExercicioFixacao();
          ExercicioResolvidoDois.ExercicioResolvidoDois.ExecutarExercicioResolvidoDois();
        }

    }
}
