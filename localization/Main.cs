using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionary{
	class MainClass{	
		//First we want to has a bank that holds all the possible keys.
		enum registeredKeys{
			gameContinue,
			gameStage,
			gameStartNew,
			gameExit,
			gameMultiplayer
		}
		
		//Here we store the different Languages + Regions
		enum languageRegion{
			jp,
			en_us,
			en_uk,
			fr_fr,
			fr_can,
			spn_spn,
			spn_mex
		}
		
		// Create and return new Hashtable.
		//Hashtable hashtable = new Hashtable();
		
		public static void Main (string[] args){	
			Console.WriteLine ("Hello World!");
			//Dictionary<registeredKeys, string> theMainDict = new Dictionary<registeredKeys, string>();
			//theMainDict.Add(registeredKeys.gameMultiplayer, "MultiJoueur");
			/*theMainDict.Add(registeredKeys.gameMultiplayer, "multijoueur");
			theMainDict.Add(registeredKeys.gameStage, "Niveau");
			theMainDict.Add(registeredKeys.gameStartNew, "Commencer");
			theMainDict.Add(registeredKeys.gameExit, "Quitter");*/
			
			//Dictionary<registeredKeys, languageRegion> segaSonic = new Dictionary<registeredKeys, languageRegion>();
		
			
			//pokemon Pikachu = new pokemon(25,"Pikachu",35,55,30,90,pokemon.theType.electric, PikachuMVList);
			keywords wordContinue = new keywords(keywords.rgistKey.gameContinue,"Continuer","Continue","Tsuzuku");
			wordContinue.getTheObjct(keywords.lngRegion.fr_can,wordContinue);
		}
		
		
		
		//Fonction avec 2 parametres
		// Param = (le mot clef,   la langue/Region)
		//On cherches dans un tableau en utilisant la clef.
		//On cherches pour la bonne traduction en utilisant le deuxieme parametre
		//On retourne le resultat 
		
		//List<string> listKeyword = new List<string>();
		
		
		
	}
	
	class keywords{
		
		public rgistKey kwrdKey;
		//public lngRegion kwrdRegion;
		public string kwrdFr;
		public string kwrdEng;
		public string kwrdJp;
		
		
		//First we want to has a bank that holds all the possible keys.
		public enum rgistKey{
			gameContinue,
			gameStage,
			gameStartNew,
			gameExit,
			gameMultiplayer
		}
		
		//Here we store the different Languages + Regions
		public enum lngRegion{
			jp,
			en_us,
			en_uk,
			fr_fr,
			fr_can,
			spn_spn,
			spn_mex
		}
		
		//Constructor
		public keywords(rgistKey theKey, /*lngRegion theRegion, */string txtFr, string txtEng, string txtJp){
			
			kwrdKey = theKey;
			//kwrdRegion = theRegion;
			kwrdFr = txtFr;
			kwrdEng = txtEng;
			kwrdJp = txtJp;
			
		}
		
		public void getTheObjct(lngRegion wantedRegion, keywords theKeyWord){
			
			switch(wantedRegion){
				case lngRegion.en_us:
					Console.WriteLine("US: " + theKeyWord.kwrdEng);
				break;
				case lngRegion.jp:
					Console.WriteLine("JAPAN: " + theKeyWord.kwrdJp);
				break;
				case lngRegion.fr_can:
					Console.WriteLine("CANADA: " + theKeyWord.kwrdFr);
				break;
			}
			
		}
		
	}
	
	
}
