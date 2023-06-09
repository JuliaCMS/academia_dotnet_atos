using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public int? FkPessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }

    public virtual ICollection<Pessoa> InverseFkPessoaNavigation { get; set; } = new List<Pessoa>();
}
