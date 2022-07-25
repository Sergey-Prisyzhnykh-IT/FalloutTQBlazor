using FalloutTQBlazor.DateBase;
using FalloutTQBlazor.GaemsControll.Player;

namespace FalloutTQBlazor.GaemsControll
{
    public static class GameControll
    {
        public static void AddCPECIALStartNewGame(int idPlayer)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var player = db.Player.FirstOrDefault(x => x.Id == idPlayer);
                if (player != null) 
                {
                    player.Level = 4;
                    player.SaveCountSPECIAL = 20;
                    db.Player.Update(player);
                    db.SaveChanges();
                }
            }
        }
    }
}
