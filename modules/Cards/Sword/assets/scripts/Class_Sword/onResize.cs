function Class_Sword::onResize(%this)
{

%this.clearCollisionShapes();

%this.createPolygonBoxCollisionShape(%this.Size);

}
