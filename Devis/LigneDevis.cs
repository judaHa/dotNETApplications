using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis
{
    class LigneDevis : Devis
    {
        string dv_code, cl_code, dv_adresse, dv_ville, dv_pays, dv_email, dv_sitew, dv_note;
        int dv_cp, dv_fixe, dv_mobile, dv_fax;
        DateTime dv_date;
        string pr_code;
        int pr_quantite;
        double pr_montant;

        public LigneDevis(string v_code, string v_cl_code, string v_adresse, string v_ville, string v_pays, string v_email, string v_sitew, string v_note, int v_cp, int v_fixe, int v_mobile, int v_fax, DateTime v_date , string v_pr_code , int v_quantite  ,double v_montant)
            : base(v_code, v_cl_code, v_adresse, v_ville, v_pays, v_email, v_sitew, v_note, v_cp, v_fixe, v_mobile, v_fax, v_date)
        {
            pr_code = v_pr_code;
            pr_quantite = v_quantite;
            pr_montant = v_montant;
        }

        public LigneDevis(string v_code) : base(v_code)
        {

        }

    }
}
