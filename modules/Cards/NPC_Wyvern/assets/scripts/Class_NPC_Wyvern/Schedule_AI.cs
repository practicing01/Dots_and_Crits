function Class_NPC_Wyvern::Schedule_AI(%this)
{

if ($Bool_A_I_Token_Bearer)
{

for (%x=0;%x<%this.Simset_Colliding_Objects.getCount();%x++)
{

%Collided_Object=%this.Simset_Colliding_Objects.getObject(%x);

//breath ram sting

}

}

%this.Schedule_AI=schedule(4000,0,"Class_NPC_Wyvern::Schedule_AI",%this);

}
