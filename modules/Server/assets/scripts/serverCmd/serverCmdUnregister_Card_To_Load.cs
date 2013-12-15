function serverCmdUnregister_Card_To_Load(%Client,%Module_ID_Card)
{

for (%x=0;%x<%Client.Simset_Cards_To_Load.getCount();%x++)
{

%Card=%Client.Simset_Cards_To_Load.getObject(%x);

if (%Card.Module_ID_Card$=%Module_ID_Card)
{

%Client.Simset_Cards_To_Load.remove(%Card);

%Card.delete();

break;

}

}

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Unregister_Card_To_Load',%Client,%Module_ID_Card);

}

}
