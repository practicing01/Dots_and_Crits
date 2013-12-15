//Need to reimplement unloading of cards

function clientCmdUnregister_Card_To_Load(%Client,%Module_ID_Card)
{

if (!isObject($Simset_Cards_To_Load)){return;}

for (%x=0;%x<$Simset_Cards_To_Load.getCount();%x++)
{

%Script_Object_Card=$Simset_Cards_To_Load.getObject(%x);

if (%Script_Object_Card.Module_ID_Card$=%Module_ID_Card)
{

if ($GameConnection_Serverside_Connection==%Client)//won't work, need to check if other players need this card
{

$Simset_Cards_To_Load.remove(%Script_Object_Card);

%Script_Object_Card.delete();

return;

}

for (%y=0;%y<$Simset_Deck_To_Load.getCount();%y++)
{

%Card=$Simset_Deck_To_Load.getObject(%y);

/*if ()
{



}*/

}

}

}

}
