# "Duck It!"

Introduction to Virtual Reality Final Project Proposal

<ol>
<li> Introduction

With the internet's ever growing influence in our daily lives, we start to see more content that we wouldn't obtain otherwise. Ducks are one of those contents. Without the internet, the influence of the species' cute yet chaotic nature may never be shared and spread out as much as it is today. This project aims to spread the joys of playing with ducks through an AR game.

<li> Background
  - Ducks and AR

Numerous species of waterfowl in the Anatidae family go by the common name "duck." Compared to swans and geese, which are all members of the same family, ducks are typically smaller and have shorter necks. "If you're going to tell a joke about an animal, make it a duck", said psychologist Richard Wiseman and colleagues at the University of Hertfordshire in the UK after completing a year-long LaughLab experiment in 2002. Due to the way ducks are perceived as being stupid in terms of their appearance or behavior, the word "duck" may have developed an intrinsic sense of humor in various languages.

Augmented reality (AR) is an interactive experience that combines the real world and computer-generated content. The content can span multiple sensory modalities, including visual, auditory, haptic, somatosensory and olfactory. AR can be defined as a system that incorporates three basic features: a combination of real and virtual worlds, real-time interaction, and accurate 3D registration of virtual and real objects.

In this project, we'd like to implement the silliness and adorability of ducks to an augmented reality game. AR has been in rising popularity since it can be more easily accessible through mobile devices instead of using a custom device for one game. Therefore in terms of making ducks that are interactive to the player and accessibility, AR would be the best option.

- Commercial Reviews

There had existed other games that put emphasis on ducks' distant cousins, which are geese. A well known geese game would be "Untitled Goose Game" which is a 2019 puzzle stealth game developed by House House and published by Panic Inc. Players control a goose who bothers the inhabitants of an English village. Another game that features ducks would be "Clusterduck", a game about hatching as many ducks as possible. As more ducks hatch, the more strange things happen. The ducks begin to genetically mutate with the chances of things going horribly wrong increase at an alarming rate.

Nowadays, there aren't many duck AR games on the internet yet. The best implementation of a duck AR is found in TikTok as a filter which allows you to pick up the duck using a detectable surface such as the palm of you hand. Sadly this filter only has one duck per filter. The duck from this filter also has some idle animations which include walking in a circle, looking at the camera and sleeping.

<li> Method
  - Project Description

This project aims to create a mobile AR game that can summon ducks around the player's real life environment so that the player can play and interact with them. The type of interactions that the players will be able to perform are summoning the ducks, feeding them and removing them by means of explosives.

- Technical Details

This project will be assisted by AR Foundation Unity, more specifically the ARCore package since we will be building this project for android platform first. To summon the ducks we will need a duck model which will be obtained from a free asset from the unity asset store. Once summoned, the ducks will have the ability to walk around, quack, eat and die.

On default, the ducks will walk around and quack at random intervals. But if the player summons some grains, the ducks will run over to the grains to eat them until they disappear. After the grains disappear the ducks will return back to their idle states. The grains will likely be one object shaped like a pyramid that becomes smaller and smaller as the ducks approach and eat them. When the grain reaches a certain size, they will disappear, setting the ducks back to their default states.

To remove ducks, the player has the ability to turn on explosive mode where they can tap on a duck to make the explode and destroy their game objects. Or they can simply click one button to explode all ducks at once. This feature is still to be decided. The explosion asset will be taken from the standard asset from the unity asset store. And destroyed by the end of it's animation cycle.

<li> Result

The results of this project is, in my opinion, satisfying. The game feels very immersive and entertaining. I even felt a little less lonely after seeing so many ducks on my phone and walking near them. Other than that, I decided to add some small features that allows the ducks to spin, sleep and quack annoyingly, which made the game far more Interesting. The awkwardness of choosing udon as the duck's food item and exploding them after we're done adds so much more to the humor. And honestly, the fact that the plane detection system by ARCore isn't the most optimum it can be yet makes it even funnier as some ducks may appear floating or upside down.

<li> Conclusion

Combining ducks and AR as a way to maximize the enjoyment of ducks was a huge success. Not only are ducks funny but the AR mechanics makes the game extra fun as well.
</ol>
Github Repository : [https://github.com/scarstreet/DuckIt-](https://github.com/scarstreet/DuckIt-)
