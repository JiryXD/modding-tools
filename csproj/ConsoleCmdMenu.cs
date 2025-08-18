using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using System.Linq;

[Preserve]
public class ConsoleCmdMenu : ConsoleCmdAbstract
{
	public override bool AllowedInMainMenu => true;

	[PublicizedFrom(EAccessModifier.Protected)]
	public override string[] getCommands()
	{
    // Cannot be simplified due to version.
		return new string[1] { "menu" };
	}

  public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
  {
    SingletonMonoBehaviour<SdtdConsole>.Instance.Output("Returning you back to the menu.");

    /* Some context:
      The XUi class utilizes the XUiFromXml class. 
      Which contains methods to load the xml in the XUI directory.

      Basically XUI holds all XUi data inside of its instance variables.
      It also holds methods and properties to gain access to the underlaying XUi elements.

      Below you can see an example of how you can extract the controller of a windowgroup and call methods on it.
    */
    XUi xui = Object.FindObjectOfType<XUi>();
    XUiController baseController = xui.FindWindowGroupByName("ingameMenu");
    
    var gameMenuWindowController = baseController.Children
    .OfType<XUiC_InGameMenuWindow>()
    .FirstOrDefault();

    gameMenuWindowController.BtnExit_OnPressed(gameMenuWindowController, 0);
	}

	[PublicizedFrom(EAccessModifier.Protected)]
	public override string getDescription()
	{
		return "Returns you to the menu.";
	}
}
