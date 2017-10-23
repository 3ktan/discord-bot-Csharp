using Discord;
using Discord.Commands;
using Discord.Audio;
using System.Net;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akebono
{
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;
        string[] stringsmug, stringbad, stringdet, stringfack, stringha, stringhaha, stringlewd, stringteehee, stringwaa, stringwtf, stringpoke;
        string[] stringauto;
        Random rand;
        private string Ship2;

        public MyBot()
        {
            discord = new DiscordClient(x =>
                {
                    x.LogLevel = LogSeverity.Info;
                    x.LogHandler = Log;
                });

            //prefix: dấu hiệu cho bot biết cmt nào là commands
            discord.UsingCommands(x =>
                {
                    x.PrefixChar = '!';
                    x.AllowMentionPrefix = true;
                });
            commands = discord.GetService<CommandService>();
            pso2_wiki(); // link cho ng mới
            meme(); //list meme
            poke(); //chọc akebono 
            help(); //danh sách command
            seach(); //seach
            eq();
			auto();

            discord.ExecuteAndWait(async () =>
                {
                    await discord.Connect("yourr bot token", TokenType.Bot); //bot token 
                });
        }

        //ảnh meme
        private void meme()
        {
            rand = new Random();
            stringbad = new string[]
            {
                "picture1/bad/bad.png",
                "picture1/bad/bad01.jpg",
                "picture1/bad/bad02.gif",
                "picture1/bad/bad03.gif",
                "picture1/bad/bad04.jpg",
                "picture1/bad/bad05.jpg",
                "picture1/bad/bad06.gif",
                "picture1/bad/bad07.jpg",
                "picture1/bad/bad08.jpg",
                "picture1/bad/bad09.jpg"
            };

            stringdet = new string[]
            {
                "picture1/det/det.jpg",
                "picture1/det/det01.jpg",
                "picture1/det/det02.png",
                "picture1/det/det03.gif",
                "picture1/det/det04.gif",
                "picture1/det/det05.jpg",
            };
            stringfack = new string[]
            {
                "picture1/fack/fack.jpg",
                "picture1/fack/fack01.jpg",
                "picture1/fack/fack02.jpg",
                "picture1/fack/fack03.jpg",
                "picture1/fack/fack04.jpg",
                "picture1/fack/fack05.jpg",
            };
            stringha = new string[]
            {
                "picture1/ha/ha01.jpg",
                "picture1/ha/ha02.jpg",
                "picture1/ha/ha03.jpg",
                "picture1/ha/ha04.jpg",
                "picture1/ha/ha05.png",
                "picture1/ha/ha06.jpg",
                "picture1/ha/ha07.jpg",
                "picture1/ha/ha08.jpg",
                "picture1/ha/ha09.png",
            };
            stringhaha = new string[]
            {
                "picture1/haha/hahaha01.jpg",
                "picture1/haha/hahaha02.gif",
                "picture1/haha/hahaha03.png",
                "picture1/haha/hahaha04.gif",
                "picture1/haha/hahaha05.jpg",
                "picture1/haha/hahaha06.gif",
                "picture1/haha/hahaha07.gif",
                "picture1/haha/hahaha08.jpg",
                "picture1/haha/hahaha09.jpg",
                "picture1/haha/hahaha10.gif",
                "picture1/haha/hahaha11.jpg",
                "picture1/haha/hahaha12.jpg",
            };
            stringlewd = new string[]
            {
                "picture1/lewd/lewd.jpg",
                "picture1/lewd/lewd01.jpg",
                "picture1/lewd/lewd02.jpg",
                "picture1/lewd/lewd03.jpg",
            };

            stringsmug = new string[]
            {
                "picture1/smug/smug.png",
                "picture1/smug/smug01.png",
                "picture1/smug/smug02.jpg",
                "picture1/smug/smug03.jpg",
                "picture1/smug/smug04.jpg",
                "picture1/smug/smug05.gif",
                "picture1/smug/smug06.jpg",
                "picture1/smug/smug07.jpg",
                "picture1/smug/smug08.png",
                "picture1/smug/smug09.jpg",
                "picture1/smug/smug10.jpg",
                "picture1/smug/smug11.jpg",
                "picture1/smug/smug12.jpg",
                "picture1/smug/smug13.jpg",
                "picture1/smug/smug14.jpg",
                "picture1/smug/smug15.jpg",
                "picture1/smug/smug16.jpg",
                "picture1/smug/smug17.jpg",
                "picture1/smug/smug18.jpg",
                "picture1/smug/smug19.jpg",
                "picture1/smug/smug20.gif" 
            };
            stringteehee = new string[]
            {
                "picture1/teehee/teehee01.png",
                "picture1/teehee/teehee02.png",
                "picture1/teehee/teehee03.png",
            };

            stringwaa = new string[]
            {
                "picture1/waa/waa.gif",
                "picture1/waa/waa01.gif",
                "picture1/waa/waa02.jpg",
            };
            stringwtf = new string[]
            {
                "picture1/wtf/wtf.gif",
                "picture1/wtf/wtf01.jpg",
                "picture1/wtf/wtf02.jpg",
            };
            commands.CreateCommand("bad")
                .Do(async (e) =>
                {
                    int randomBad = rand.Next(stringbad.Length);
                    string BadToPost = stringbad[randomBad];
                    await e.Channel.SendFile(BadToPost);
                });
            commands.CreateCommand("det")
                .Do(async (e) =>
                {
                    int randomDet = rand.Next(stringdet.Length);
                    string DetToPost = stringdet[randomDet];
                    await e.Channel.SendFile(DetToPost);
                });
            commands.CreateCommand("fack")
                .Do(async (e) =>
                {
                    int randomFack = rand.Next(stringfack.Length);
                    string FackToPost = stringfack[randomFack];
                    await e.Channel.SendFile(FackToPost);
                });
            commands.CreateCommand("ha")
                .Do(async (e) =>
                {
                    int randomHa = rand.Next(stringha.Length);
                    string HaToPost = stringha[randomHa];
                    await e.Channel.SendFile(HaToPost);
                });

            commands.CreateCommand("haha")
                .Do(async (e) =>
                {
                    int randomHaha = rand.Next(stringhaha.Length);
                    string HahaToPost = stringhaha[randomHaha];
                    await e.Channel.SendFile(HahaToPost);
                });
            commands.CreateCommand("lewd")
                .Do(async (e) =>
                {
                    int randomLewd = rand.Next(stringlewd.Length);
                    string LewdToPost = stringlewd[randomLewd];
                    await e.Channel.SendFile(LewdToPost);
                });
            commands.CreateCommand("smug")
                .Do(async (e) =>
                { 
                    int randomSmug = rand.Next(stringsmug.Length);
                    string SmugToPost = stringsmug[randomSmug];
                    await e.Channel.SendFile(SmugToPost); 
                });
            commands.CreateCommand("teehee")
                .Do(async (e) =>
                {
                    int randomTeehee = rand.Next(stringteehee.Length);
                    string TeeheeToPost = stringteehee[randomTeehee];
                    await e.Channel.SendFile(TeeheeToPost);
                });
            commands.CreateCommand("waa")
                .Do(async (e) =>
                {
                    int randomWaa = rand.Next(stringwaa.Length);
                    string WaaToPost = stringwaa[randomWaa];
                    await e.Channel.SendFile(WaaToPost);
                });
            commands.CreateCommand("wtf")
                .Do(async (e) =>
                {
                    int randomWtf = rand.Next(stringwtf.Length);
                    string WtfToPost = stringwtf[randomWtf];
                    await e.Channel.SendFile(WtfToPost);
                });
        }// end ảnh meme
        // link cho newbie
        private void pso2_wiki() 
        {
            commands.CreateCommand("newbie")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://3ktan.wordpress.com/2016/07/05/pso2_co-ban-cho-nguoi-moi-ver-2/");
                });
            commands.CreateCommand("mag")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://3ktan.wordpress.com/2016/08/12/pso2-mag/");
                });
            commands.CreateCommand("tree")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://3ktan.wordpress.com/2016/09/26/pso2_build-tree-cach-choi/");
                });
            commands.CreateCommand("swiki")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("http://pso2.swiki.jp/index.php");
                });
        }//end link cho newbie

        

        //poke
        private void poke()
        {
            rand = new Random();
            stringpoke = new string[]
            {
                "Sao anh lại đụng vào tôi, thật phiền quá đi.",
                "Gì đó? Có việc gì à?",
                "Sao anh cứ chạm vào tôi thế? Anh không có cơ hội đâu",
                "Nếu anh không thích tôi, sao không phân công tôi sang chỗ đội khác đi?",
                "Nếu anh không thích tôi, sao không phân công tôi sang chỗ khác đi?... N-nó không phiền gì đâu.",
                "Nghiêm túc đi, đây không phải lúc để đùa đâu.",
                "Không biết tôi phải nói bao nhiêu lần thì anh mới hiểu đây? Rằng tôi cực kì ghét anh, đô đốc thúi ạ!... Sao anh không tin tôi chứ? ",
            };

            commands.CreateCommand("poke")
                .Do(async (e) =>
                {
                    int randomPoke = rand.Next(stringpoke.Length);
                    string PokeToPost = stringpoke[randomPoke];
                    await e.Channel.SendMessage(e.User.Name + ": " + PokeToPost);

                });
        }//end poke

        //help
        private void help()
        {
            commands.CreateCommand("help")
                .Do(async (e) =>
                    {
                        await e.Channel.SendMessage(" \n ```Link cho newbie:```\n`!newbie`: Cơ bản cho người mới chơi \n`!mag`: Mag là gì? Xài như thế nào? \n`!tree`: cách build tree và kiểu chơi \n`!swiki`: Wiki PSO2 tiếng Nhật \n ```Meme list:``` \n `!bad` \n `!det`: cái đệt! \n `!fack` \n `!ha`: khi không hiểu gì đó \n `!haha`: cười lớn \n `!lewd`: lewd chat \n `!smug`: cười đểu \n `!teehee` :P \n `!waa`: buồn quá, khóc rồi :'< \n `!wtf`");
                    });
        }//end help

        //chưa dùng
        private void auto()
        {
            rand = new Random();
            stringauto = new string[]
            {
                "qq", "bb", "pp", "dd"
            };

            discord.MessageReceived += async (s, e) =>
            {
                if (e.Message.RawText.Contains("qq"))
                {
                    int randomAuto = rand.Next(stringauto.Length);
                    string AutoToPost = stringauto[randomAuto];
                    await e.Channel.SendMessage(AutoToPost);
                }
            };
        }

        //seach
        private void seach()
        {
            commands.CreateCommand("seach3ktan").Parameter("message", ParameterType.Multiple)
                .Do(async (e) =>
                {
                    string message = "";
                    for (int i = 0; i < e.Args.Length; i++)
                    {
                        message += e.Args[i].ToString() + "+";
                    }
                    await e.Channel.SendMessage("https://3ktan.wordpress.com/?s=" + message);
                });
        }// end seach

        private void RegisterShutdownCommand()
        {  
            commands.CreateCommand("exit")
                .Do((e) =>
                    {
                        if (e.User.Id != 270757591418667010)
                        {
                            /*Code to execute when its not the owner.*/
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    });

        }

        public class RootObject
        {
             public string HalfHour { get; set; }
             public string JST { get; set; }
             public bool Maintenance { get; set; }
             public string Now { get; set; }
             public string OneHalfLater { get; set; }
             public string OneLater { get; set; }
             public string Ship1 { get; set; }
             public string Ship10 { get; set; }
             public string Ship2 { get; set; }
             public string Ship3 { get; set; }
             public string Ship4 { get; set; }
             public string Ship5 { get; set; }
             public string Ship6 { get; set; }
             public string Ship7 { get; set; }
             public string Ship8 { get; set; }
             public string Ship9 { get; set; }
             public string ThreeHalfLater { get; set; }
             public string ThreeLater { get; set; }
             public string TwoHalfLater { get; set; }
             public string TwoLater { get; set; }
        }

        private void eq()
        {
            using (var webClient = new System.Net.WebClient())
            {

                var json = webClient.DownloadString("http://pso2.acf.me.uk/api/eq.json");
                Console.WriteLine(json["now"]);
                commands.CreateCommand("eq")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage(json);
                });
            }
            
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
