using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationGestionCommerciale.Entity
{
    class Client
    {
        private int _code_Client;
        private String _ref_Client;
        private String _nom_Client;
        private String _prenom_Client;
        private String _adresse_Client;
        private int _codepostal_Client;
        private String _ville_Client;
        private String _pays_Client;
        private int _telFixe_Client;
        private int _telMobile_Client;
        private String _email_Client;
        private String _site_Client;
        private int _fax_Client;
        private String _societe_Client;
        private String _etat_Client;
        private int _nbTransactions_Client;
        private String _notes_Client;
        //_____________________________________________________________________________

        public Client() { }

        public int code_Client
        {
            get { return this._code_Client; }
            set { this._code_Client = value; }
        }


        //*******************************************************************************

        public String ref_Client
        {
            get { return this._ref_Client; }
            set { this._ref_Client = value; }
        }


        //*******************************************************************************

        public String nom_Client
        {
            get { return this._nom_Client; }
            set { this._nom_Client = value; }
        }
        //*******************************************************************************
        public String prenom_Client
        {
            get { return this._prenom_Client; }
            set { this._prenom_Client = value; }
        }

        //*******************************************************************************
        public String adresse_Client
        {
            get { return this._adresse_Client; }
            set { this._adresse_Client = value; }
        }

        //*******************************************************************************
        public int codepostal_Client
        {
            get { return this._codepostal_Client; }
            set { this._codepostal_Client = value; }
        }

        //*******************************************************************************

        public String ville_Client
        {
            get { return this._ville_Client; }
            set { this._ville_Client = value; }
        }

        //*******************************************************************************

        public String pays_Client
        {
            get { return this._pays_Client; }
            set { this._pays_Client = value; }
        }

        //*******************************************************************************


        public int telFixe_Client
        {
            get { return this._telFixe_Client; }
            set { this._telFixe_Client = value; }
        }

        //*******************************************************************************



        public int telMobile_Client
        {
            get { return this._telMobile_Client; }
            set { this._telMobile_Client = value; }
        }


        //*******************************************************************************

        public String email_Client
        {
            get { return this._email_Client; }
            set { this._email_Client = value; }
        }

        //*******************************************************************************



        //*******************************************************************************


        public int fax_Client
        {
            get { return this._fax_Client; }
            set { this._fax_Client = value; }
        }


        //*******************************************************************************

        public String site_Client
        {
            get { return this._site_Client; }
            set { this._site_Client = value; }
        }
        //*******************************************************************************




        public String societe_Client
        {
            get { return this._societe_Client; }
            set { this._societe_Client = value; }
        }

        //*******************************************************************************



        public String etat_Client
        {
            get { return this._etat_Client; }
            set { this._etat_Client = value; }
        }

        //*******************************************************************************



        public int nbTransactions_Client
        {
            get { return this._nbTransactions_Client; }
            set { this._nbTransactions_Client = value; }
        }

        //*******************************************************************************

        public String notes_Client
        {
            get { return this._notes_Client; }
            set { this._notes_Client = value; }
        }



        //*******************************************************************************
        //*******************************************************************************
        //*******************************************************************************


        public Client(int _code_Client,String _ref_Client, String _nom_Client, String _prenomClient, String _adresse_Client,int _codepostal_Client, String _ville_Client, String _pays_Client, int _telFixe_Client, int _telMobile_Client, int _fax_Client, String _email_Client, String _site_Client, String _societe_Client, String _etat_Client, int _nbTransactions_Client, String _notes_Client)
        {
            _code_Client = code_Client;
            _ref_Client = ref_Client;
            _nom_Client = nom_Client;
            _prenom_Client = prenom_Client;
            _adresse_Client = adresse_Client;
            _codepostal_Client = codepostal_Client;
            _ville_Client = ville_Client;
            _pays_Client = pays_Client;
            _telFixe_Client = telFixe_Client;
            _telMobile_Client = telMobile_Client;
            _email_Client = email_Client;
            _fax_Client = fax_Client;
            _societe_Client = societe_Client;
            _etat_Client = etat_Client;
            _site_Client = site_Client;
            _nbTransactions_Client = nbTransactions_Client;
            _notes_Client = notes_Client;

        }



    }
}
