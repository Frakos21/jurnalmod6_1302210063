// See https://aka.ms/new-console-template for more information
using jurnalmod6_1302210063;
using System.Reflection.Metadata;

SayaTubeUser user = new SayaTubeUser("INI");
SayaTubeVideo video1 = new SayaTubeVideo("judul");
user.AddVideo(video1);

user.PrintAllVideosPlaycount();



