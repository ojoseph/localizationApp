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
			gameMultiplayer,
			gameOnlineMode
		}
		
		//Here we store the different Languages + Regions
		enum languageRegion{
			jp = 1,
			en_us = 0,
			en_uk = 7,
			fr_fr = 5,
			fr_can = 2,
			spn_spn = 9,
			spn_mex = 3
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
		static List<string> gameStartNew = new List<string>(new string[] { "New Game", "Hajime", "Nouvelle Partie", "Nuevo Juego" } );
		static List<string> gameExit = new List<string>(new string[] { "Quit", "Owari", "Quitter", "parar" } );
		static List<string> gameMultiplayer = new List<string>(new string[] { "Multiplayer", "muuchiplay", "Multi-Jouers", "Multijugador" } );
		static List<string> gameContinue = new List<string>(new string[] { "Continue", "Tsuzuku", "Continuer", "Continuar" } );
		static List<string> gameOnlineMode = new List<string>(new string[] { "Online", "Onrainu", "En ligne", "en línear" } );
		
		
		//The function has 2 options, register or display
		static void translateWord(registeredKeys theRegKey, languageRegion theRegion, List<string> theValues){
			
			//We check to see if the user tried to call for  a word that does not exist in a region
			if((int)theRegion > theValues.Count){
				
				Console.WriteLine("<!> The translation for this has yet to be translated <!>.");	
			
			}else{
			
			
				//Before Registering we check if it already exists
				if (theTrslDict.ContainsKey(theRegKey)) {
					Console.WriteLine("Sorry " +theTrslDict[theRegKey][(int)theRegion] +" is already registered!");
					//We display it
					Console.WriteLine("Requested Translation: " + theTrslDict[theRegKey][(int)theRegion]);
				}else{
					//We register the key
					theTrslDict.Add(theRegKey, theValues);
					//Console.WriteLine("New key "+ theTrslDict[theRegKey][(int)theRegion] +" is  now registered! ");
					Console.WriteLine(theTrslDict[theRegKey][(int)theRegion] +" +1");
				}
				
	
			}
		}
		
	
		public static void Main (string[] args){
			//We call the translations here
			translateWord(registeredKeys.gameContinue, languageRegion.jp, gameContinue);
			translateWord(registeredKeys.gameMultiplayer, languageRegion.jp, gameMultiplayer);
			translateWord(registeredKeys.gameExit, languageRegion.jp, gameExit);
			translateWord(registeredKeys.gameStartNew, languageRegion.jp, gameStartNew);
			translateWord(registeredKeys.gameStartNew, languageRegion.jp, gameStartNew);
			translateWord(registeredKeys.gameOnlineMode, languageRegion.fr_can, gameOnlineMode);
			translateWord(registeredKeys.gameOnlineMode, languageRegion.spn_mex, gameOnlineMode);
			translateWord(registeredKeys.gameOnlineMode, languageRegion.en_uk, gameOnlineMode);
		}
	}
	
	
}
