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
    class meme
    {
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
    }
}