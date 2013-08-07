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
			Dictionary<registeredKeys, string> theMainDict = new Dictionary<registeredKeys, string>();
			//theMainDict.Add(registeredKeys.gameMultiplayer, "MultiJoueur");
			theMainDict.Add(registeredKeys.gameMultiplayer, "multijoueur");
			theMainDict.Add(registeredKeys.gameStage, "Niveau");
			theMainDict.Add(registeredKeys.gameStartNew, "Commencer");
			theMainDict.Add(registeredKeys.gameExit, "Quitter");
			
			
			//Here we test the output
			Console.WriteLine(theMainDict[registeredKeys.gameExit]);
		}
		
		
		
	}
}
