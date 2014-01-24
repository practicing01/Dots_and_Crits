function Class_NPC_Wyvern::Schedule_AI(%this)
{

if ($Bool_A_I_Token_Bearer)
{

if (%this.Simset_Colliding_Objects.getCount())
{

%Collided_Object=%this.Simset_Colliding_Objects.getObject(0);//First in, first to die :D.

//breath ram sting
%Random_Attack=getRandom(0,2);

if (%Random_Attack==0)
{



}

}

}

%this.Schedule_AI=schedule(2000,0,"Class_NPC_Wyvern::Schedule_AI",%this);

}
