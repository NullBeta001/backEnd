using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;
            }else if (rendimento <= 6000)
            {
                return rendimento * .05f;
            }else if (rendimento <= 10000)
            {
                return rendimento * .07f;
            }else
            {
                return rendimento * .09f;                
            }
        }

        public bool ValidarCnpj(string Cnpj)
        {
            throw new NotImplementedException();
        }
    }
}