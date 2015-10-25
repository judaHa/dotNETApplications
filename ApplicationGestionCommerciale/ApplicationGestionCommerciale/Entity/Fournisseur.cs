using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationGestionCommerciale.Entity
{
    class Fournisseur
    {
        private int _idFournisseur;
        private String _ref_Fournisseur;
        private String _nom_Fournisseur;
        private String _prenom_Fournisseur;
        private String _adresse_Fournisseur;
        private int _codePostal_Fournisseur;
        private String _ville_Fournisseur;
        private String _pays_Fournisseur;
        private int _tel_Fournisseur;
        private int _telmobile_Fournisseur;
        private String _email_Fournisseur;
        private int _fax_Fournisseur;
        private String _siteInternet_Fournisseur;
        private String _etat_Fournisseur;
        private int _nb_transactions_Fournisseur;
        private String _note_Fournisseur;
        //_____________________________________________________________________________

        public Fournisseur() { }

        public int idFournisseur
        {
            get { return this._idFournisseur; }
            set { this._idFournisseur = value; }
        }

        //*******************************************************************************

        public String ref_Fournisseur
        {
            get { return this._ref_Fournisseur; }
            set { this._ref_Fournisseur = value; }
        }

        //*******************************************************************************

        public String nom_Fournisseur
        {
            get { return this._nom_Fournisseur; }
            set { this._nom_Fournisseur = value; }
        }
        //*******************************************************************************
        public String prenom_Fournisseur
        {
            get { return this._prenom_Fournisseur; }
            set { this._prenom_Fournisseur = value; }
        }

        //*******************************************************************************
        public String adresse_Fournisseur
        {
            get { return this._adresse_Fournisseur; }
            set { this._adresse_Fournisseur = value; }
        }


        //*******************************************************************************

        public int codePostal_Fournisseur
        {
            get { return this._codePostal_Fournisseur; }
            set { this._codePostal_Fournisseur = value; }
        }

        //*******************************************************************************

        public String ville_Fournisseur
        {
            get { return this._ville_Fournisseur; }
            set { this._ville_Fournisseur = value; }
        }

        //*******************************************************************************

        public String pays_Fournisseur
        {
            get { return this._pays_Fournisseur; }
            set { this._pays_Fournisseur = value; }
        }

        //*******************************************************************************


        public int tel_Fournisseur
        {
            get { return this._tel_Fournisseur; }
            set { this._tel_Fournisseur = value; }
        }

        //*******************************************************************************


        public int telmobile_Fournisseur
        {
            get { return this._telmobile_Fournisseur; }
            set { this._telmobile_Fournisseur = value; }
        }

        //*******************************************************************************


        public String email_Fournisseur
        {
            get { return this._email_Fournisseur; }
            set { this._email_Fournisseur = value; }
        }

        //*******************************************************************************


        public int fax_Fournisseur
        {
            get { return this._fax_Fournisseur; }
            set { this._fax_Fournisseur = value; }
        }


        //*******************************************************************************

        public String siteInternet_Fournisseur
        {
            get { return this._siteInternet_Fournisseur; }
            set { this._siteInternet_Fournisseur = value; }
        }
        //*******************************************************************************



        public String etat_Fournisseur
        {
            get { return this._etat_Fournisseur; }
            set { this._etat_Fournisseur = value; }
        }

        //*******************************************************************************



        public int nb_transactions_Fournisseur
        {
            get { return this._nb_transactions_Fournisseur; }
            set { this._nb_transactions_Fournisseur = value; }
        }

        //*******************************************************************************

        public String note_Fournisseur
        {
            get { return this._note_Fournisseur; }
            set { this._note_Fournisseur = value; }
        }



        //*******************************************************************************
        //*******************************************************************************
        //*******************************************************************************


        public Fournisseur(int _idFournisseur,String _ref_Fournisseur ,String _nom_Fournisseur, String _prenom_Fournisseur, String _adresse_Fournisseur, int _codePostal_Fournisseur, String _ville_Fournisseur, String _pays_Fournisseur, int _tel_Fournisseur,int _telmobile_Fournisseur, int _fax_Fournisseur, String _email_Client, String _site_Fournisseur, String _etat_Fournisseur, int _nb_transactions_Fournisseur, String _note_Fournisseur)
        {
            _idFournisseur = idFournisseur;
            _ref_Fournisseur = ref_Fournisseur;
            _nom_Fournisseur = nom_Fournisseur;
            _prenom_Fournisseur = prenom_Fournisseur;
            _adresse_Fournisseur = adresse_Fournisseur;
            _codePostal_Fournisseur = codePostal_Fournisseur;
            _ville_Fournisseur = ville_Fournisseur;
            _pays_Fournisseur = pays_Fournisseur;
            _tel_Fournisseur = tel_Fournisseur;
            _telmobile_Fournisseur = telmobile_Fournisseur;
            _email_Fournisseur = email_Fournisseur;
            _fax_Fournisseur = fax_Fournisseur;
            _etat_Fournisseur = etat_Fournisseur;
            _siteInternet_Fournisseur = siteInternet_Fournisseur;
            _nb_transactions_Fournisseur = nb_transactions_Fournisseur;
            _note_Fournisseur = note_Fournisseur;

        }


    }
}
