using ETModel;
using ETHotfix.LoginPack;
using UnityEngine;
namespace ETHotfix{
	[ObjectSystem]
	public class LoginComponentStartSystem : StartSystem<LoginComponent>
	{
		public override void Start(LoginComponent self)
		{
#region FieldCode 

		    var login2RegisterController= self.login2RegisterController;



		    var RegAccInContent= self.RegAccIn.text;

		    var RegPWInContent= self.RegPWIn.text;

		    var RegConfirmInContent= self.RegConfirmIn.text;

		    var pwInContent= self.pwIn.text;


		    var accInContent= self.accIn.text;


		    self.bgBtn.self.onClick.Add(OnbgBtnClick);

		    self.ConfirmBtn.self.onClick.Add(OnConfirmBtnClick);

		    self.loginBtn.self.onClick.Add(OnloginBtnClick);

		    self.regBtn.self.onClick.Add(OnregBtnClick);

 #endregion

#region MethodCode 
		    void OnbgBtnClick()
		    {

		    }
		    void OnConfirmBtnClick()
		    {

		    }
		    void OnloginBtnClick()
		    {

		    }
		    void OnregBtnClick()
		    {

		    }

 #endregion
       }
	}
	[ObjectSystem]
	public class LoginComponentUpdateSystem : UpdateSystem<LoginComponent>
	{
		public override void Update(LoginComponent self)
		{
            
		}
	}
	[ObjectSystem]
	public class LoginComponentDestroySystem : DestroySystem<LoginComponent>
	{
		public override void Destroy(LoginComponent self)
		{
            
		}
	}
}