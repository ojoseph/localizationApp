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
			jp = 1,
			en_us = 0,
			en_uk = 7,
			fr_fr = 5,
			fr_can = 2,
			spn_spn = 9,
			spn_mex =10
		}
		
		//decides if the user displays or register the info
		enum transAct{
			register,
			display
		}
		//#################################################################################################
		// New dict -> FCT
		//#################################################################################################
		
		//Main holder
		static Dictionary<registeredKeys, List<string> > theTrslDict = new Dictionary<registeredKeys, List<string> >();
		
		
		//We initiate the  dictionaries
		static List<string> gameStartNew = new List<string>(new string[] { "New Game", "Hajime", "Nouvelle Partie" } );
		static List<string> gameExit = new List<string>(new string[] { "Quit", "Owari", "Quitter" } );
		
		//The function has 2 options, register or display
		static void findTranslation(registeredKeys theRegKey, languageRegion theRegion, List<string> theValues, transAct theAction){
			switch(theAction){
				case transAct.register:
					//Before Registering we check if it already exists
					if (theTrslDict.ContainsKey(theRegKey)) {
						Console.WriteLine("Sorry This key is already registered!");
					}else{
						//We register the key
						Console.WriteLine("New key is registered!");
						theTrslDict.Add(theRegKey, theValues);
					}
				break;
				case transAct.display:
					//We display the keyword
					Console.WriteLine("Requested Translation: " + theTrslDict[theRegKey][(int)theRegion]);
				break;
			}
		}
		
		
	
		public static void Main (string[] args){
			//registerKeyword(registeredKeys.gameStartNew ,gameStartNew);
			//registerKeyword(registeredKeys.gameExit ,gameExit);
			
			findTranslation(registeredKeys.gameStartNew, languageRegion.jp, gameStartNew, transAct.register);
			findTranslation(registeredKeys.gameStartNew, languageRegion.jp, gameStartNew, transAct.register);
			findTranslation(registeredKeys.gameStartNew, languageRegion.jp, gameStartNew, transAct.display);
			
			/*findTranslation(registeredKeys.gameStartNew, languageRegion.jp, gameStartNew);
			findTranslation(registeredKeys.gameExit, languageRegion.jp, gameExit);
			findTranslation(registeredKeys.gameExit, languageRegion.en_us, gameExit);*/
			
			
			
			
			
			
			Console.WriteLine ("Hello World!");
		
			keywords wordContinue = new keywords(keywords.rgistKey.gameContinue,"Continuer","Continue","Tsuzuku");
			wordContinue.getTheObjct(wordContinue,keywords.lngRegion.fr_can);
			
			keywords wordGameStage = new keywords(keywords.rgistKey.gameStage,"Niveau","Stage","Sute-ji");
			wordGameStage.getTheObjct(wordGameStage,keywords.lngRegion.jp);
			
			//#################################################################################################
			// New dict
			//#################################################################################################
			List<string> someTestList = new List<string>(new string[] { "english", "japanese", "french" } );
			
			//Console.WriteLine("---->" + someTestList[1]);
			List<string> wordStage = new List<string>(new string[] { "Stage", "Sute-ji", "Niveau" } );
			
			
			
			Dictionary<registeredKeys, List<string> > theDict = new Dictionary<registeredKeys, List<string> >();
			theDict.Add(registeredKeys.gameContinue, someTestList);
			theDict.Add(registeredKeys.gameStage, wordStage);
			Console.WriteLine("EEEE: " + theDict[registeredKeys.gameContinue][(int)languageRegion.fr_can]);
			Console.WriteLine("RRRR: " + theDict[registeredKeys.gameStage][(int)languageRegion.fr_can]);
			
			
			
			//#################################################################################################
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
		
		public void getTheObjct(keywords theKeyWord, lngRegion wantedRegion){
			
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
