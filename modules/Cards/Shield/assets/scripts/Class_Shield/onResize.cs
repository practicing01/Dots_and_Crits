function Class_Shield::onResize(%this)
{

%this.clearCollisionShapes();

%this.createPolygonBoxCollisionShape(%this.Size);

}
