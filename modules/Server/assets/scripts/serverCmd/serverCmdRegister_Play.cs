function serverCmdRegister_Play(%Client)
{

%Client.Is_Playing=true;

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Register_Play',%Client);

}

//Send cards.

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

if (%Object.Is_Playing)
{

for (%y=0;%y<%Object.Simset_Cards_To_Load.getCount();%y++)
{

%Card=%Object.Simset_Cards_To_Load.getObject(%y);

commandToClient(%Client,'Register_Card_To_Load',%Card.Module_ID_Card);

}

}

}

}
