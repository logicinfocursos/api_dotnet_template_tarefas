﻿using System.ComponentModel;

namespace SistemaDeTarefas.Data.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        Afazer = 1,

        [Description("Em Andamento")]
        EmAndamento = 2,

        [Description("Concluído")]
        Concluido = 3
    }
}
