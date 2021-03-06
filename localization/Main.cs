using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionary{
	
	class MainClass{	
		//First we want to have a bank that holds all the possible keys.
		enum rgstKey{
			gameContinue,
			gameStage,
			gameStartNew,
			gameExit,
			gameMultiplayer,
			gameOnlineMode
		}
		
		//Here we store the different Languages + Regions
		enum lngReg{
			jp = 1,
			en_us = 0,
			en_uk = 7,
			fr_fr = 5,
			fr_can = 2,
			spn_spn = 9,
			spn_mex = 3
		}
	
		//#################################################################################################
		// New dict -> FCT Note: We use static as the ojb does not require and instance 
		//#################################################################################################
		
		//Main Dictionary, we use an enum as a key and fill the info with a list.
		static Dictionary<rgstKey, List<string> > theTrslDict = new Dictionary<rgstKey, List<string> >();
		
		//We initiate the  dictionaries the index will guide us for which region we are calling for
		static List<string> gameStartNew = new List<string>(new string[] { "New Game", "Hajime", "Nouvelle Partie", "Nuevo Juego" } );
		static List<string> gameExit = new List<string>(new string[] { "Quit", "Owari", "Quitter", "Parar" } );
		static List<string> gameMultiplayer = new List<string>(new string[] { "Multiplayer", "muuchiplay", "Multi-Jouers", "Multijugador" } );
		static List<string> gameContinue = new List<string>(new string[] { "Continue", "Tsuzuku", "Continuer", "Continuar" } );
		static List<string> gameOnlineMode = new List<string>(new string[] { "Online", "Onrainu", "En ligne", "En línear" } );
		
		
		//The function has 2 options, register or display
		static void translateWord(rgstKey theRegKey, lngReg theRegion, List<string> theValues){
			
			//We check to see if the user tried to call for  a word that does not exist in a region/not translated yet
			if((int)theRegion > theValues.Count){
				
				Console.WriteLine("<!> This word has yet to be translated <!>.");	
			
			}else{
			
				//Before Registering we check if it already exists
				if (theTrslDict.ContainsKey(theRegKey)) {
					//We warn the user that it already exists
					Console.WriteLine("Sorry " +theTrslDict[theRegKey][(int)theRegion] +" is already registered!");
					//We help the user by giving him the translation anyways. (This prevents the fct to have a set and not set)
					Console.WriteLine("Requested Translation: " + theTrslDict[theRegKey][(int)theRegion]);
				}else{
					//We register the key
					theTrslDict.Add(theRegKey, theValues);
					//Console.WriteLine("New key "+ theTrslDict[theRegKey][(int)theRegion] +" is  now registered! ");
					Console.WriteLine(theTrslDict[theRegKey][(int)theRegion] +" +1");
				}
	
			}
		}//End TranslateWord
		
	
		public static void Main (string[] args){
			//We call the translations here
			translateWord(rgstKey.gameContinue, lngReg.jp, gameContinue);
			translateWord(rgstKey.gameMultiplayer, lngReg.jp, gameMultiplayer);
			translateWord(rgstKey.gameExit, lngReg.jp, gameExit);
			translateWord(rgstKey.gameStartNew, lngReg.jp, gameStartNew);
			translateWord(rgstKey.gameStartNew, lngReg.jp, gameStartNew);
			translateWord(rgstKey.gameOnlineMode, lngReg.fr_can, gameOnlineMode);
			translateWord(rgstKey.gameOnlineMode, lngReg.spn_mex, gameOnlineMode);
			translateWord(rgstKey.gameOnlineMode, lngReg.en_uk, gameOnlineMode);
		}
		
	}//End Main class
	
	
}
