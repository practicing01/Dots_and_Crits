function clientCmdRegister_Play(%Game_Connection_Server_Side)
{

%Player_Name=0;

for (%x=0;%x<$Simset_Players_Information.getCount();%x++)
{

%Player_Information=$Simset_Players_Information.getObject(%x);

if (%Player_Information.Game_Connection_Handle==%Game_Connection_Server_Side)
{

%Player_Information.Is_Playing=true;

%Player_Name=%Player_Information.Connector_Name;

if ($Bool_Is_Playing)
{

Module_Player_Class.Player_Data_Add(%Player_Information);

}
else if (%Game_Connection_Server_Side==$GameConnection_Serverside_Connection)
{

$Bool_Is_Playing=true;

Dots_and_Crits.Load_Play();

}

break;

}

}

if (isObject(Gui_List_Previous_Text))
{

%Gui_TextCtrl=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Player_Name SPC "is playing."; 
Extent="200 100";
isContainer="0";
Profile="GuiTextProfile";
hovertime="1000";
MaxLength="255";
};

Gui_List_Previous_Text.add(%Gui_TextCtrl);

if (Gui_List_Previous_Text.getCount()>10)
{
Gui_List_Previous_Text.remove(Gui_List_Previous_Text.getObject(0));
}

Gui_Scroller_Previous_Text.computeSizes();

Gui_Scroller_Previous_Text.scrollToBottom();

}

}
