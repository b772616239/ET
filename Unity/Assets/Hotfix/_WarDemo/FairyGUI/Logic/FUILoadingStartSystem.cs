using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using UnityEngine;

namespace ETHotfix.Common
{
    [ObjectSystem]
    public class FUILoadingStartSystem : UpdateSystem<FUILoading>
    {
     




        public override void Update(FUILoading self)
        {
            Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", "start", "test1"));
            var bar = self.loadingBar.self;
            bar.value += Time.deltaTime * 10;
            self.loadingText.text = bar.value.ToString("F1");
            if (bar.value >= 100)
            {
                bar.value = 0;
            }
        }
    }
}