function serverCmdRegister_Card_To_Load(%Client,%Module_ID_Card)
{

%Bool_Has_Card=false;

for (%x=0;%x<%Client.Simset_Cards_To_Load.getCount();%x++)
{

%Card=%Client.Simset_Cards_To_Load.getObject(%x);

if (%Card.Module_ID_Card$=%Module_ID_Card)
{

%Bool_Has_Card=true;break;

}

}

if (!%Bool_Has_Card)
{

%Card=new ScriptObject()
{

Module_ID_Card=%Module_ID_Card;

};

%Client.Simset_Cards_To_Load.add(%Card);

}

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Register_Card_To_Load',%Module_ID_Card);

}

}
