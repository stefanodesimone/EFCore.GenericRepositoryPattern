using System;
using System.Collections.Generic;

namespace App.API.Models;

public partial class Utenti
{
    public int IdUser { get; set; }

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Abilitato { get; set; }
}
