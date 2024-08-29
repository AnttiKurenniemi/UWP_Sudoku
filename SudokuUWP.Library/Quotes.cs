using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuUWP.Library
{
    public class Quote
    {
        public string Text { get; set; }
        public string Author { get; set; } = "";
    }

    public static class QuoteList
    {
        private static Random random = new Random();

        private static List<Quote> Quotes = new List<Quote>
        {
            #region 1 - 100

            new Quote { Text = "To each his sufferings: all are men, condemn'd alike to groan the tender for another's pain, th' unfeeling for his own. Yet, ah! why should they know their fate, since sorrow never comes too late, and happiness too swiftly flies? Thought would destroy their Paradise. No more; Where ignorance is bliss, 'tis folly to be wise.", Author = "Thomas Gray" },
            new Quote { Text = "The metric system is the tool of the devil! My car gets forty rods to the hogshead and that's the way I likes it.", Author = "Abe Simpson" },
            new Quote { Text = "If Barbie is so popular, why do you have to buy her friends?", Author = "Steven Wright" },
            new Quote { Text = "A verbal contract is not worth the paper it's written on.", Author = "Samuel Goldwyn" },
            new Quote { Text = "Facts are stupid things.", Author = "Ronald Reagan" },
            new Quote { Text = "Solutions are not the answer.", Author = "Richard Nixon" },
            new Quote { Text = "I knew I was an unwanted baby when I saw that my bath toys were a toaster and a radio.", Author = "Joan Rivers" },
            new Quote { Text = "I don't feel we did wrong in taking this great country away from them. There were great numbers of people who needed new land, and the Indians were selfishly trying to keep it for themselves.", Author = "John Wayne" },
            new Quote { Text = "Happiness is your dentist telling you it won't hurt and then having him catch his hand in the drill.", Author = "Johnny Carson" },
            new Quote { Text = "Every tooth in a man's head is more valuable than a diamond.", Author = "Miguel de Cervantes, Don Quixote" },
            // = 10

            new Quote { Text = "If suffering brought wisdom, the dentist’s office would be full of luminous ideas." , Author = "Mason Cooley" },
            new Quote { Text = "You don't have to brush your teeth - just the ones you want to keep." , Author = "Unknown" },
            new Quote { Text = "Some tortures are physical and some are mental, but the one that is both is dental.", Author = "Ogden Nash" },
            new Quote { Text = "Too many of today's children have straight teeth and crooked morals." , Author = "Unknown high school principal" },
            new Quote { Text = "The man with a toothache thinks everyone happy whose teeth are sound." , Author = "George Bernard Shaw" },
            new Quote { Text = "Dentist: a prestidigitator who, putting metal into your mouth, pulls coin out of your pocket." , Author = "Ambrose Bierce" },
            new Quote { Text = "I find that most men would rather have their bellies opened for five hundred dollars than have a tooth pulled for five.", Author = "Martin H. Fischer" },
            new Quote { Text = "For there was never yet philosopher that could endure the toothache patiently.", Author = "William Shakespeare, Much Ado About Nothing" },
            new Quote { Text = "We do have a zeal for laughter in most situations, give or take a dentist." , Author = "Joseph Heller" },
            new Quote { Text = "Even pearls are dark before the whiteness of his teeth.", Author = "William R. Alger" },
            // = 20

            new Quote { Text = "If a patient cannot clean his teeth, no dentist can clean them for him." , Author = "Martin H. Fischer" },
            new Quote { Text = "An aching tooth is better out than in. To lose a rotting member is a gain.", Author = "Richard Baxter, Poetical Fragments" },
            new Quote { Text = "My health plan doesn't cover dental, so I enrolled my teeth as 32 dependents, each needing a complete physical once a year.", Author = "Robert Brault, www.robertbrault.com" },
            new Quote { Text = "A man loses his illusions first, his teeth second, and his follies last.", Author = "Helen Rowland" },
            new Quote { Text = "There are two things in life that a sage must preserve at every sacrifice, the coats of his stomach and the enamel of his teeth. Some evils admit of consolations, but there are no comforters for dyspepsia and the toothache." , Author = "Henry Lytton Bulwer" },
            new Quote { Text = "You know, sometimes a man just can't satisfy all of a woman's desires.  Which is why God invented dental floss.", Author = "Author Unknown" },
            new Quote { Text = "Adam and Eve had many advantages, but the principal one was that they escaped teething.", Author = "Mark Twain" },
            new Quote { Text = "The tongue is ever turning to the aching tooth.", Author = "Thomas Fuller" },
            new Quote { Text = "Some old women and men grow bitter with age; the more their teeth drop out, the more biting they get.", Author = "George D. Prentice" },
            new Quote { Text = "I had very good dentures once.  Some magnificent gold work. It's the only form of jewelry a man can wear that women fully appreciate." , Author = "Graham Greene" },
            // = 30

            new Quote { Text = "I'm always amazed to hear of air crash victims so badly mutilated that they have to be identified by their dental records.  What I can't understand is, if they don't know who you are, how do they know who your dentist is?", Author = "Paul Merton" },
            new Quote { Text = "Tooth decay was a perennial national problem that meant a mouthful of silver for patients, and for dentists a pocketful of gold.", Author = "Claudia Wallis " },
            new Quote { Text = "If it weren't for electricity we'd all be watching television by candlelight." , Author = "George Gobel" },
            new Quote { Text = "There is no housing shortage in Lincoln today - just a  rumour that is put about by people who have nowhere to live.", Author = "G.L. Murfin, Mayor of Lincoln" },
            new Quote { Text = "Beyond its entertainment value, Baywatch has enriched and, in many cases, helped save lives. I'm looking forward to the opportunity to continue with a project which has has such a significance for so many.", Author = "David Hasselhoff, Actor" },
            new Quote { Text = "Many people would sooner die than think; in fact, they do so." , Author = "Bertrand Russell" },
            new Quote { Text = "Many a man will have the courage to die gallantly, but will not have the courage to say, or even to think, that the cause for which he is asked to die is an unworthy one.", Author = "Bertrand Russell" },
            new Quote { Text = "Liberty is the right to do what I like; license, the right to do what you like." , Author = "Bertrand Russell" },
            new Quote { Text = "It is preoccupation with possessions, more than anything else, that prevents us from living freely and nobly.", Author = "Bertrand Russell" },
            new Quote { Text = "In America everybody is of the opinion that he has no social superiors, since all men are equal, but he does not admit that he has no social inferiors, for, from the time of Jefferson onward, the doctrine that all men are equal applies only upwards, not downwards.", Author = "Bertrand Russell" },
            // = 40

            new Quote { Text = "If there were in the world today any large number of people who desired their own happiness more than they desired the unhappiness of others, we could have a paradise in a few years.", Author = "Bertrand Russell" },
            new Quote { Text = "I've made an odd discovery. Every time I talk to a savant I feel quite sure that happiness is no longer a possibility. Yet when I talk with my gardener, I'm convinced of the opposite.", Author = "Bertrand Russell" },
            new Quote { Text = "I think we ought always to entertain our opinions with some  measure of doubt. I shouldn't wish people dogmatically to  believe any philosophy, not even mine." , Author = "Bertrand Russell" },
            new Quote { Text = "I remain convinced that obstinate addiction to ordinary language in our private thoughts is one of the main obstacles to progress in philosophy." , Author = "Bertrand Russell" },
            new Quote { Text = "Freedom in general may be defined as the absence of obstacles  to the realization of desires." , Author = "Bertrand Russell" },
            new Quote { Text = "Democracy is the process by which people choose the man who'll  get the blame." , Author = "Bertrand Russell" },
            new Quote { Text = "A lot of these people who keep a gun at home for safety are the same ones who refuse to wear a seat belt." , Author = "George Carlin" },
            new Quote { Text = "New programmers are drawn to multithreading like moths to flame, with similar results." , Author = "Tweet by Danny Thorpe" },
            new Quote { Text = "Heck, I don't age in my mind - people around me just keep getting younger.  :^)", Author = "Van Swofford in e.p.delphi.non-technical" },
            new Quote { Text = "The clue train passed his station without stopping.", Author = "John Simmons / outlaw programmer" },
            // = 50

            new Quote { Text = "Real programmers just throw a bunch of 1s and 0s at the computer to see what sticks" , Author = "Pete O'Hanlon" },
            new Quote { Text = "Not only do you continue to babble nonsense, you can't even correctly remember the nonsense you babbled just minutes ago.", Author = "Rob Graham" },
            new Quote { Text = "Acton's Law: Power tends to corrupt; absolute power corrupts absolutely." },
            new Quote { Text = "Albrecht's Law: Social innovations tend to the level of minimum tolerable well-being." },
            new Quote { Text = "Allen's (or Cann's) Axiom: When all else fails, read the instructions." },
            new Quote { Text = "Boren's First Law: When in doubt, mumble." },
            new Quote { Text = "Bo Diddeley's Observation On The Law: Always take a lawyer with you, and bring another lawyer to watch him." },
            new Quote { Text = "Bove's Theorem: The remaining work to finish in order to reach your goal increases as the deadline approaches." },
            new Quote { Text = "Bowie's Theorem: If an experiment works, you must be using the wrong equipment." },
            new Quote { Text = "Brilliant's Observation On Modern Art: Not all our artists are playing a joke on the public. Some are genuinely mad." },
            // 60

            new Quote { Text = "Brilliant's Law Of Limited Ambition: If you can't learn how to do it well, learn how to enjoy doing it poorly." },
            new Quote { Text = "Brook's Law: Adding manpower to a late software project makes it later." },
            new Quote { Text = "Carlson's Consolation: Nothing is ever a complete failure; it can always serve as a bad example." },
            new Quote { Text = "Clarke's Third Law: Any sufficiently advanced technology is indistinguishable from magic." },
            new Quote { Text = "Cohn's Law: The more time you spend in reporting on what you are doing, the less time you have to do anything.  Stability is achieved when you spend all your time reporting on the nothing you are doing." },
            new Quote { Text = "Conway's Law: In any organization there will always be one person who knows what is going on.  This person must be fired." },
            new Quote { Text = "Law Of Continuity: Experiments should be reproducible. They should all fail in the same way." },
            new Quote { Text = "Correspondence Corollary: An experiment may be considered a success if no more than half of your data must be discarded to obtain correspondence with your theory." },
            new Quote { Text = "Cropp's Law: The amount of work done varies inversely with the amount of time spent in the office." },
            new Quote { Text = "Cutler Webster's Law: There are two sides to every argument, unless a person is personally involved, in which case there is only one." },
            // 70

            new Quote { Text = "Deadline-Dan's Demo Demonstration: The higher the 'higher-ups' are who've come to see your demo, the lower your chances are of giving a successful one." },
            new Quote { Text = "Deadline-Dan's Demon: Every task takes twice as long as you think it will take. If you double the time you think it will take, it will actually take four times as long." },
            new Quote { Text = "Denniston's Law: Virtue is its own punishment." },
            new Quote { Text = "Dow's Law: In a hierarchical organization, the higher the level, the greater the confusion." },
            new Quote { Text = "Dr. Caligari's Come-Back: A bad sector disk error occurs only after you've done several hours of work without performing a backup." },
            new Quote { Text = "Estridge's Law: No matter how large and standardized the marketplace is, IBM can redefine it." },
            new Quote { Text = "Finagle's Law Of Government Contracting: Dealing with the government is like kicking a 300-pound sponge." },
            new Quote { Text = "Finster's Law: A closed mouth gathers no feet." },
            new Quote { Text = "First Rule Of History: History doesn't repeat itself, historians merely repeat each other." },
            new Quote { Text = "Flo Capp's Observation: The next best thing to doing something smart is not doing something stupid." },
            // 80

            new Quote { Text = "Franklin's Rule: Blessed is the end user who expects nothing, for he/she will not be disappointed." },
            new Quote { Text = "Glyme's Formula For Success: The secret of success is sincerity. Once you can fake that, you've got it made." },
            new Quote { Text = "Goebel's Law Of Useless Difficulty: Just because it's hard Doesn't mean it's worth the effort." },
            new Quote { Text = "Goebel's Second Law Of Useless Difficulty: The fastest way to get something done is to determine that it isn't worth doing." },
            new Quote { Text = "Goebel's Theorem Of Software Schedules: Always multiply a software schedule by pi.  This is because you think you're going in a straight line but always end up going full circle." },
            new Quote { Text = "Goebel's Law Of Product Introductions: A future product release date does NOT say when a product will be introduced.  All it says it that you don't have a chance in HELL of seeing it before that time." },
            new Quote { Text = "Goebel's Observation On Utopia: If everyone believed in Peace they would immediately begin fighting over the best way to achieve it." },
            new Quote { Text = "The Golden Rule Of Arts And Sciences: Whoever has the gold makes the rules." },
            new Quote { Text = "Gold's Law: If the shoe fits, it's ugly." },
            new Quote { Text = "Gordon's First Law: If a research project is not worth doing at all, it is not worth doing well." },
            // 90

            new Quote { Text = "Government's Law: There is an exception to all laws." },
            new Quote { Text = "Green's Law Of Debate: Anything is possible if you don't know what you're talking about." },
            new Quote { Text = "Gummidges's Law: The amount of expertise varies in inverse proportion to the number of statements understood by the general public." },
            new Quote { Text = "Gumperson's Law: The probability of a given event occurring is inversely proportional to its desirability." },
            new Quote { Text = "Hanlon's Razor: Never attribute to malice that which is adequately explained by stupidity." },
            new Quote { Text = "Harrison's Postulate: For every action, there is an equal and opposite criticism." },
            new Quote { Text = "Heller's Law: The first myth of management is that it exists." },
            new Quote { Text = "Hoare's Law Of Large Programs: Inside every large program is a small program struggling to get out." },
            new Quote { Text = "Hubbard's Law: Don't take life too seriously; you won't get out of it alive." },
            new Quote { Text = "Jenkinson's Law: It won't work." },
            // 100

            #endregion

            #region 101 - 200

            new Quote { Text = "Johnson-Laird's Law: Toothache tends to start on Saturday night." },
            new Quote { Text = "Larkinson's Law: All laws are basically false." },
            new Quote { Text = "Lieberman's Law: Everybody lies; but it doesn't matter, since nobody listens." },
            new Quote { Text = "Lynch's Law: When the going gets tough, everyone leaves." },
            new Quote { Text = "Mason's First Law Of Synergism: The one day you'd sell your soul for something, souls are a glut." },
            new Quote { Text = "Mencken's Law: There is always an easy answer to every human problem: neat, plausible, and wrong." },
            new Quote { Text = "Meskimen's Law: There's never time to do it right, but always time to do it over." },
            new Quote { Text = "Muir's Law: When we try to pick out anything by itself, we find it hitched to everything else in the universe." },
            new Quote { Text = "Murphy's Fourth Law: If there is a possibility of several things going wrong, the one that will cause the most damage will be the one to go wrong." },
            new Quote { Text = "Murphy's Law Of Thermodynamics: Things get worse under pressure." },
            // 110

            new Quote { Text = "Ninety-ninety Rule Of Project Schedules: The first ninety percent of the task takes ninety percent of the time, and the last ten percent takes the other ninety percent." },
            new Quote { Text = "Nixon's Theorem: The man who can smile when things go wrong has thought of someone he can blame it on." },
            new Quote { Text = "Nolan's Placebo: An ounce of image is worth a pound of performance." },
            new Quote { Text = "Oliver's Law Of Location: No matter where you are, there you are." },
            new Quote { Text = "O'Reilly's Law Of The Kitchen: Cleanliness is next to impossible." },
            new Quote { Text = "O'Toole's Commentary On Murphy's Law: Murphy was an optimist." },
            new Quote { Text = "Parkinson's Law: Work expands to fill the time available for its completion." },
            new Quote { Text = "Peter's Principle: In every hierarchy, each employee tends to rise to the level of his incompetence." },
            new Quote { Text = "The Law Of The Perversity Of Nature: You cannot determine beforehand which side of the bread to butter." },
            new Quote { Text = "Robert E. Lee's Truce: Judgement comes from experience; experience comes from poor judgement." },
            // 120

            new Quote { Text = "Rudin's Law: In a crisis that forces a choice to be made among alternative courses of action, people tend to choose the worst possible course." },
            new Quote { Text = "Rule Of Accuracy: When working toward the solution of a problem it always helps you to know the answer." },
            new Quote { Text = "Ryan's Law: Make three correct guesses consecutively and you will establish yourself as an expert." },
            new Quote { Text = "Sattinger's Law: It works better if you plug it in." },
            new Quote { Text = "Sausage Principle: People who love sausage and respect the law should never watch either one being made." },
            new Quote { Text = "Shaw's Principle: Build a system that even a fool can use, and only a fool will want to use it." },
            new Quote { Text = "Stewart's Law Of Retroaction: It is easier to get forgiveness than permission." },
            new Quote { Text = "The Law Of The Too Solid Goof: In any collection of data, the figures that are obviously correct beyond all need of checking contain the errors." },
            new Quote { Text = "Weiler's Law: Nothing is impossible for the man who doesn't have to do the work." },
            new Quote { Text = "Weinberg's Corollary: An expert is a person who avoids the small errors while sweeping on to the grand fallacy." },
            // 130

            new Quote { Text = "Weinberg's Law: If builders built buildings the way programmers write programs, then the first woodpecker that came along would destroy civilization." },
            new Quote { Text = "Whitehead's Law: The obvious answer is always overlooked." },
            new Quote { Text = "Wilcox's Law: A pat on the back is only a few centimeters from a kick in the pants." },
            new Quote { Text = "Wood's Axiom: As soon as a still-to-be-finished computer task becomes a life-or-death situation, the power fails." },
            new Quote { Text = "Woodward's Law: A theory is better than its explanation." },
            new Quote { Text = "Zymurgy's First Law Of Evolving System Dynamics: Once you open a can of worms, the only way to recan them is to use a larger can." },
            new Quote { Text = "You can't rush good cooking, you can't rush babies out, and you can't rush software development", Author = "Unknown" },
            new Quote { Text = "To eat well in England, you should have breakfast three times a day." , Author = "W. Somerset Maugham" },
            new Quote { Text = "Maybe her popularity stems from the fact that watching her is sometimes like watching a train wreck.", Author = "John McCain's daughter Meghan about Ann Coulter" },
            new Quote { Text = "I told my wife that I had a living will: I do not wish to be fed liquids from a bottle and hooked to a machine. So she turned off the TV and threw away the beer." , Author = "Bob Hipsley" },
            // 140

            new Quote { Text = "The only function of economic forecasting is to make astrology look respectable." , Author = "John Kenneth Galbraith" },
            new Quote { Text = "I do not find in Christianity one redeeming feature.", Author = "Thomas Jefferson" },
            new Quote { Text = "If you can't be a good example, then you'll just have to serve as a horrible warning." , Author = "Catherine Aird" },
            new Quote { Text = "And the users exclaimed with a laugh and a taunt: 'It's just what we asked for but not what we want.'" },
            new Quote { Text = "If the lessons of history teach us anything it is that nobody learns the lessons that history teaches us." },
            new Quote { Text = "Real computer scientists despise the idea of actual hardware. Hardware has limitations, software doesn't. It's a real shame that Turing machines are so poor at I/O." },
            new Quote { Text = "Sufficiently advanced incompetence is indistinguishable from malice." },
            new Quote { Text = "Theory is when you know something, but it doesn't work. Practice is when something works, but you don't know why. Programmers combine theory and practice: Nothing works and they don't know why." },
            new Quote { Text = "If there's one thing worse than a program that doesn't work when it should, it's a program that does work when it shouldn't.", Author = "Bob Archer" },
            new Quote { Text = "There's a fine line between being on the leading edge and being in the lunatic fringe." , Author = "Frank Armstrong" },
            // 150

            new Quote { Text = "Once a new technology starts rolling, if you're not part of the steamroller, you're part of the road." , Author = "Stewart Brand" },
            new Quote { Text = "Einstein argued that there must be simplified explanations of nature, because God is not capricious or arbitrary. No such faith comforts the software engineer." , Author = "Fred Brooks" },
            new Quote { Text = "Good judgement comes from experience, and experience comes from bad judgement." , Author = "Fred Brooks" },
            new Quote { Text = "Plan to throw one away, you will anyhow." , Author = "Fred Brooks" },
            new Quote { Text = "The first 90% of the code accounts for the first 90% of the development time. The remaining 10% of the code accounts for the other 90% of the development time." , Author = "Tom Cargill" },
            new Quote { Text = "The behavior of any bureaucratic organization can best be understood by assuming that it is controlled by a secret cabal of its enemies." , Author = "Robert Conquest's Second Law of Politics" },
            new Quote { Text = "Programmers are in a race with the Universe to create bigger and better idiot-proof programs, while the Universe is trying to  create bigger and better idiots. So far the Universe is winning.", Author = "Rich Cook" },
            new Quote { Text = "It has been said that the great scientific disciplines are examples of giants standing on the shoulders of other giants. It has also been said that the software industry is an example of midgets standing on the toes of other midgets.", Author = "Alan Cooper" },
            new Quote { Text = "Style distinguishes excellence from accomplishment.", Author = "James Coplien" },
            new Quote { Text = "Learning is not compulsory. Neither is survival.", Author = "W. Edwards Deming" },
            // 160

            new Quote { Text = "To iterate is human, to recurse divine." , Author = "L. Peter Deutsch" },
            new Quote { Text = "Just because the standard provides a cliff in front of you, you are not necessarily required to jump off it.", Author = "Norman Diamond" },
            new Quote { Text = "Simplicity is prerequisite for reliability" , Author = "Edsger W. Dijkstra" },
            new Quote { Text = "The competent programmer is fully aware of the strictly limited size of his own skull; therefore he approaches the programming task in full humility, and among other things he avoids clever tricks like the plague." , Author = "Edsger Dijkstra" },
            new Quote { Text = "Do not worry about your difficulties in mathematics. I can assure you that mine are still greater." , Author = "Albert Einstein" },
            new Quote { Text = "Make everything as simple as possible, but not simpler.", Author = "Albert Einstein" },
            new Quote { Text = "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe." , Author = "Albert Einstein" },
            new Quote { Text = "I have always found that plans are useless, but planning is indispensable." , Author = "Dwight Eisenhower" },
            new Quote { Text = "A foolish consistency is the hobgoblin of little minds, adored by little statesmen and philosophers and divines.", Author = "Ralph Waldo Emerson" },
            new Quote { Text = "For a sucessful technology, honesty must take precedence over public relations for nature cannot be fooled." , Author = "Richard Feynman" },
            // 170

            new Quote { Text = "The first principle is that you must not fool yourself - and you are the easiest person to fool." , Author = "Richard Feynman" },
            new Quote { Text = "The inside of a computer is as dumb as hell but it goes like mad!" , Author = "Richard Feynman" },
            new Quote { Text = "One of the main causes of the fall of the Roman Empire was that, lacking zero, they had no way to indicate successful termination of their C programs." , Author = "Robert Firth" },
            new Quote { Text = "There is not now, nor has there ever been, nor will there ever be, any programming language in which it is the least bit difficult to write bad code." , Author = "Flon's Law" },
            new Quote { Text = "Comparing to another activity is useful if it helps you formulate questions, it's dangerous when you use it to justify answers.", Author = "Martin Fowler" },
            new Quote { Text = "Simplicity carried to the extreme becomes elegance.", Author = "Jon Franklin" },
            new Quote { Text = "Measuring programming progress by lines of code is like measuring aircraft building progress by weight." , Author = "Bill Gates" },
            new Quote { Text = "How the teacher reacts when something goes wrong tells the class what's important." , Author = "Bruce Hamilton" },
            new Quote { Text = "The road to wisdom? Well it's plain and simple to express: Err and err and err again, but less and less and less." , Author = "Piet Hein" },
            new Quote { Text = "We are apt to shut our eyes against a painful truth.... For my part, I am willing to know the whole truth; to know the worst; and to provide for it." , Author = "Patrick Henry" },
            // 180

            new Quote { Text = "The ability to simplify means to eliminate the unnecessary so that the necessary may speak." , Author = "Hans Hoffmann" },
            new Quote { Text = "It's not at all important to get it right the first time. It's vitally important to get it right the last time.", Author = "Andrew Hunt and David Thomas" },
            new Quote { Text = "It's so easy to become mesmerized by the immediacy of a result that you don't question its validity." , Author = "Naomi Karten" },
            new Quote { Text = "We are faced with an insurmountable opportunity." , Author = "W. Kelley" },
            new Quote { Text = "Trying to outsmart a compiler defeats much of the purpose of using one.", Author = "Kernighan and Plauger" },
            new Quote { Text = "A charlatan makes obscure what is clear; a thinker makes clear what is obscure." , Author = "Hugh Kingsmill" },
            new Quote { Text = "Any inaccuracies in this index may be explained by the fact that it has been sorted with the help of a computer.", Author = "Donald Knuth: Sorting and Searching" },
            new Quote { Text = "Computers are good at following instructions, but not at reading your mind." , Author = "Donald Knuth" },
            new Quote { Text = "These machines have no common sense; they have not yet learned to 'think', and they do exactly as they are told, no more and no less. This fact is the hardest concept to grasp when one first tries to use a computer." , Author = "Donald Knuth" },
            new Quote { Text = "You're bound to be unhappy if you optimize everything.", Author = "Donald Knuth" },
            // 190

            new Quote { Text = "The perfect project plan is possible if one first documents a list of all the unknowns." , Author = "Bill Langley" },
            new Quote { Text = "Without stress nothing would move." , Author = "Bill Langley" },
            new Quote { Text = "There is nothing more difficult to carry out, nor more doubtful of success, nor more dangerous to handle, than to initiate a new order of things. For the reformer has enemies in all those who profit by the old order, and only lukewarm defenders in all those who would profit by the new...", Author = "Niccolo Macchiavelli" },
            new Quote { Text = "You can't have great software without a great team, and most software teams behave like dysfunctional families." , Author = "Jim McCarthy" },
            new Quote { Text = "Incompetents invariably make trouble for people other than themselves." , Author = "Larry McMurtry" },
            new Quote { Text = "Haste is of the devil. Slowness is of God." , Author = "H L Mencken" },
            new Quote { Text = "Say what you will about the Ten Commandments, you must always come back to the pleasant fact that there are only ten of them.", Author = "H. L. Mencken" },
            new Quote { Text = "Unformed people delight in the gaudy and in novelty. Cooked people delight in the ordinary." , Author = "Erik Naggum" },
            new Quote { Text = "Any fool can use a computer. Many do." , Author = "Ted Nelson" },
            new Quote { Text = "There's no sense being exact about something if you don't even know what you're talking about." , Author = "John von Neumann" },
            // 200

            #endregion

            #region 201 - 300

            new Quote { Text = "That's the thing about people who think they hate computers. What they really hate is lousy programmers." , Author = "Larry Niven and Jerry Pournelle" },
            new Quote { Text = "The truth does not change according to our ability to stomach it." , Author = "Flannery O'Connor" },
            new Quote { Text = "Elegance is not optional" , Author = "Richard O'Keefe" },
            new Quote { Text = "The best performance improvement is the transition from the nonworking state to the working state" , Author = "John Ousterhout" },
            new Quote { Text = "Alas, to wear the mantle of Galileo it is not enough that you be persecuted by an unkind establishment, you must also be right." , Author = "Bob Park" },
            new Quote { Text = "Copy and paste is a design error" , Author = "David Parnas" },
            new Quote { Text = "Every program has (at least) two purposes: the one for which it was written, and another for which it wasn't." , Author = "Alan J. Perlis" },
            new Quote { Text = "There are two ways to write error-free programs; only the third works." , Author = "Alan J. Perlis" },
            new Quote { Text = "Thank you for sending me a copy of your book; I'll waste no time reading it.", Author = "Moses Hadas" },
            new Quote { Text = "He can compress the most words into the smallest idea of any man I know.", Author = "Abraham Lincoln" },
            // 210

            new Quote { Text = "When someone says, 'I want a programming language in which I need only say what I want done', give him a lollipop." , Author = "Alan Perlis" },
            new Quote { Text = "Some problems are so complex that you have to be highly intelligent and well informed just to be undecided about them." , Author = "Laurence J. Peter" },
            new Quote { Text = "The most amazing achievement of the computer software industry is its continuing cancellation of the steady and staggering gains made by the computer hardware industry." , Author = "Henry Petroski" },
            new Quote { Text = "Computers are useless. They can only give you answers." , Author = "Pablo Picasso" },
            new Quote { Text = "Technology is dominated by two types of people: Those who understand what they do not manage, and those who manage what they do not understand." , Author = "Putt's Law" },
            new Quote { Text = "I have never killed a man, but I have read many obituaries with great pleasure." , Author = "Clarence Darrow" },
            new Quote { Text = "UNIX is simple. It just takes a genius to understand its simplicity." , Author = "Dennis Ritchie" },
            new Quote { Text = "We only acknowledge small faults in order to make it appear that we are free from great ones." , Author = "La Rochefoucauld" },
            new Quote { Text = "Even if you're on the right track, you'll get run over if you just sit there." , Author = "Will Rogers" },
            new Quote { Text = "The trouble with the world is that the stupid are cocksure and the intelligent are full of doubt." , Author = "Bertrand Russell" },
            // 220

            new Quote { Text = "A mathematician is a machine for turning coffee into theorems." , Author = "Alfréd Rényi (also attributed to Paul Erdös)" },
            new Quote { Text = "You know you've achieved perfection in design, not when you have nothing more to add, but when you have nothing more to take away." , Author = "Antoine de Saint-Exupery" },
            new Quote { Text = "Fashion is something barbarous, for it produces innovation without reason and imitation without benefit." , Author = "George Santayana" },
            new Quote { Text = "Those who cannot remember the past are condemned to repeat it." , Author = "George Santayana" },
            new Quote { Text = "It is difficult to get a man to understand something when his salary depends on his not understanding it." , Author = "Upton Sinclair" },
            new Quote { Text = "If you lie to the compiler, it will get its revenge." , Author = "Henry Spencer" },
            new Quote { Text = "Without requirements or design, programming is the art of adding bugs to an empty text file." , Author = "Louis Srygley" },
            new Quote { Text = "The primary duty of an exception handler is to get the error out of the lap of the programmer and into the surprised face of the user. Provided you keep this cardinal rule in mind, you can't go far wrong." , Author = "Verity Stob" },
            new Quote { Text = "We are tied down to a language which makes up in obscurity what it lacks in style." , Author = "Tom Stoppard" },
            new Quote { Text = "A modest little person, with much to be modest about." , Author = "Winston Churchill" },
            // 230

            new Quote { Text = "A notation is important for what it leaves out." , Author = "Joseph Stoy" },
            new Quote { Text = "I have always wished that my computer would be as easy to use as my telephone. My wish has come true. I no longer know how to use my telephone." , Author = "Bjarne Stroustrup" },
            new Quote { Text = "Lord, give us the wisdom to utter words that are gentle and tender, for tomorrow we may have to eat them." , Author = "Rep. Morris Udall" },
            new Quote { Text = "Simplicity is the ultimate sophistication." , Author = "Leonardo da Vinci" },
            new Quote { Text = "The best is the enemy of the good." , Author = "Voltaire" },
            new Quote { Text = "A lady came up to me on the street, pointed at my suede jacket and said, 'Don't you know a cow was murdered for that jacket?' I said 'I didn't know there were any witnesses. Now I'll have to kill you too'." , Author = "George Carlin" },
            new Quote { Text = "Future historians will be able to study at the Jimmy Carter Library, the Gerald Ford Library, the Ronald Reagan Library, and the Bill Clinton Adult Bookstore." , Author = "George Carlin" },
            new Quote { Text = "Benny Goodman plays the clarinet. I play music." , Author = "Artie Shaw" },
            new Quote { Text = "He had delusions of adequacy." , Author = "Walter Kerr" },
            new Quote { Text = "He has all the virtues I dislike and none of the vices I admire." , Author = "Winston Churchill" },
            // 240

            new Quote { Text = "Most of you are familiar with the virtues of a programmer. There are three, of course: laziness, impatience, and hubris." , Author = "Larry Wall" },
            new Quote { Text = "We all agree on the necessity of compromise. We just can't agree on when it's necessary to compromise." , Author = "Larry Wall" },
            new Quote { Text = "Power is the ability to control things, moral authority is the ability to change things" , Author = "Jim Wallis" },
            new Quote { Text = "The pessimist complains about the wind; the optimist expects it to change; the realist adjusts the sails." , Author = "William Arthur Ward" },
            new Quote { Text = "They always say time changes things, but you actually have to change them yourself." , Author = "Andy Warhol" },
            new Quote { Text = "More computing sins are committed in the name of efficiency (without necessarily achieving it) than for any other single reason - including blind stupidity." , Author = "W.A. Wulf" },
            new Quote { Text = "The purpose of software engineering is to control complexity, not to create it." , Author = "Dr. Pamela Zave" },
            new Quote { Text = "Some people, when confronted with a problem, think 'I know, I'll use regular expressions.' Now they have two problems." , Author = "Jamie Zawinski" },
            new Quote { Text = "They show you how detergents take out bloodstains. I think if you've got a T-shirt with bloodstains all over it, maybe your laundry isn't your biggest problem." , Author = "George Carlin" },
            new Quote { Text = "Ask people why they have deer heads on their walls and they tell you it's because they're such beautiful animals. I think my wife is beautiful, but I only have photographs of her on the wall." , Author = "George Carlin" },
            // 250

            new Quote { Text = "If you plan to throw one away, you will throw away two." , Author = "Craig Zerouni" },
            new Quote { Text = "Debugging is twice as hard as writing the code in the first place. Therefore, if you write the code as cleverly as possible, you are, by definition, not smart enough to debug it." , Author = "Brian Kernighan" },
            new Quote { Text = "The city's central computer told you?  R2D2, you know better than to trust a strange computer!" , Author = "C3PO" },
            new Quote { Text = "Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live." , Author = "Martin Golding" },
            new Quote { Text = "I don't care if it works on your machine! We are not shipping your machine!" , Author = "Vidiu Platon" },
            new Quote { Text = "A computer lets you make more mistakes faster than any invention in human history - with the possible exceptions of handguns and tequila." , Author = "Mitch Radcliffe" },
            new Quote { Text = "The trouble with having an open mind, of course, is that people will insist on coming along and trying to put things in it." , Author = "Terry Pratchett (Diggers)" },
            new Quote { Text = "Give a man a fire and he's warm for the day, but set fire to him and he's warm for the rest of his life." , Author = "Terry Pratchett (Jingo)" },
            new Quote { Text = "It is said that your life flashes before your eyes just before you die. That is true, it's called Life." , Author = "Terry Pratchett (The Last Continent)" },
            new Quote { Text = "One out of every three Americans is suffering from some form of mental illness. Think of two of your best friends. If they are OK, then it must be you." , Author = "George Carlin" },
            // 260

            new Quote { Text = "If cats looked like frogs we'd realize what nasty, cruel little bastards they are. Style. That's what people remember." , Author = "Terry Pratchett (Lords and Ladies)" },
            new Quote { Text = "Stories of imagination tend to upset those without one." , Author = "Terry Pratchett" },
            new Quote { Text = "In ancient times cats were worshipped as gods; they have not forgotten this." , Author = "Terry Pratchett" },
            new Quote { Text = "It's not worth doing something unless someone, somewhere, would much rather you weren't doing it." , Author = "Terry Pratchett" },
            new Quote { Text = "Time is a drug. Too much of it kills you." , Author = "Terry Pratchett (Small Gods)" },
            new Quote { Text = "I'll be more enthusiastic about encouraging thinking outside the box when there's evidence of any thinking going on inside it." , Author = "Terry Pratchett" },
            new Quote { Text = "In the beginning there was nothing, which exploded." , Author = "Terry Pratchett (Lords and Ladies)" },
            new Quote { Text = "Wisdom comes from experience. Experience is often a result of lack of wisdom." , Author = "Terry Pratchett" },
            new Quote { Text = "Real stupidity beats artificial intelligence every time." , Author = "Terry Pratchett (Hogfather)" },
            new Quote { Text = "Five exclamation marks, the sure sign of an insane mind." , Author = "Terry Pratchett (Reaper Man)" },
            // 270

            new Quote { Text = "If you have enough book space, I don't want to talk to you." , Author = "Terry Pratchett" },
            new Quote { Text = "Coming back to where you started is not the same as never leaving." , Author = "Terry Pratchett (A Hat Full of Sky)" },
            new Quote { Text = "A good bookshop is just a genteel Black Hole that knows how to read." , Author = "Terry Pratchett (Guards! Guards!)" },
            new Quote { Text = "It would seem that you have no useful skill or talent whatsoever,' he said. 'Have you thought of going into teaching?" , Author = "Terry Pratchett (Mort)" },
            new Quote { Text = "I'd rather be a climbing ape than a falling angel." , Author = "Terry Pratchett" },
            new Quote { Text = "There is a rumour going around that I have found God. I think this is unlikely because I have enough difficulty finding my keys, and there is empirical evidence that they exist." , Author = "Terry Pratchett" },
            new Quote { Text = "He'd been wrong, there was a light at the end of the tunnel, and it was a flamethrower." , Author = "Terry Pratchett (Mort)" },
            new Quote { Text = "If complete and utter chaos was lightning, then he'd be the sort to stand on a hilltop in a thunderstorm wearing wet copper armour and shouting 'All gods are bastards!'" , Author = "Terry Pratchett (The Color of Magic)" },
            new Quote { Text = "Ever notice that anyone going slower than you is an idiot, but anyone going faster is a maniac?" , Author = "George Carlin" },
            new Quote { Text = "I have six locks on my door, all in a row. When I go out, I lock every other one. I figure no matter how long somebody stands there picking the locks, they are always locking three of them." , Author = "George Carlin" },
            // 280

            new Quote { Text = "She was already learning that if you ignore the rules people will, half the time, quietly rewrite them so that they don't apply to you." , Author = "Terry Pratchett (Equal Rites)" },
            new Quote { Text = "This isn't life in the fast lane, it's life in the oncoming traffic." , Author = "Terry Pratchett" },
            new Quote { Text = "Fantasy is an exercise bicycle for the mind. It might not take you anywhere, but it tones up the muscles that can. Of course, I could be wrong." , Author = "Terry Pratchett" },
            new Quote { Text = "Always be wary of any helpful item that weighs less than its operating manual." , Author = "Terry Pratchett (Jingo)" },
            new Quote { Text = "Many people, meeting Aziraphale for the first time, formed three impressions: that he was English, that he was intelligent, and that he was gayer than a treeful of monkeys on nitrous oxide." , Author = "Terry Pratchett (Good Omens)" },
            new Quote { Text = "The presence of those seeking the truth is infinitely to be preferred to the presence of those who think they've found it." , Author = "Terry Pratchett (Monstrous Regiment)" },
            new Quote { Text = "Chaos is found in greatest abundance wherever order is being sought. It always defeats order, because it is better organized." , Author = "Terry Pratchett (Interesting Times)" },
            new Quote { Text = "The three rules of the Librarians of Time and Space are: 1) Silence; 2) Books must be returned by no later than the date shown; and 3) Do not interfere with the nature of causality." , Author = "Terry Pratchett (Guards! Guards!)" },
            new Quote { Text = "Studies have shown that an ant can carry one hundred times its own weight, but there is no known limit to the lifting power of the average tiny eighty-year-old Spanish peasant grandmother." , Author = "Terry Pratchett (Reaper Man)" },
            new Quote { Text = "We who think we are about to die will laugh at anything." , Author = "Terry Pratchett (Night Watch)" },
            // 290

            new Quote { Text = "I do note with interest that old women in my books become young women on the covers... this is discrimination against the chronologically gifted." , Author = "Terry Pratchett" },
            new Quote { Text = "It's still magic even if you know how it's done." , Author = "Terry Pratchett (A Hat Full of Sky)" },
            new Quote { Text = "If there was anything that depressed him more than his own cynicism, it was that quite often it still wasn't as cynical as real life." , Author = "Terry Pratchett (Guards! Guards!)" },
            new Quote { Text = "Insanity is catching." , Author = "Terry Pratchett (Making Money)" },
            new Quote { Text = "For animals, the entire universe has been neatly divided into things to (a) mate with, (b) eat, (c) run away from, and (d) rocks." , Author = "Terry Pratchett (Equal Rites)" },
            new Quote { Text = "You don't elect politicians to commit crimes; you elect politicians to make your crimes legal." , Author = "Matt Taibbi" },
            new Quote { Text = "Is your argument that the Creator of the Universe was working under a deadline and His manager forced Him to rush inefficient designs into production?" , Author = "John B. Breckenridge in bpot" },
            new Quote { Text = "If you have a procedure with 10 parameters, you probably missed some." , Author = "Alan Perlis" },
            new Quote { Text = "Real Programmers never work from 9 to 5. If any real programmer is around at 9 a.m., it's because they were up all night." , Author = "Some Computer Geek" },
            new Quote { Text = "Ever notice when you blow in a dog's face he gets mad at you, but when you take him in a car he sticks his head out the window?" , Author = "George Carlin" },
            // 300

            #endregion

            #region 301 - 400

            new Quote { Text = "Hardware : The parts of a computer system that can be kicked." , Author = "Jeff Pesis" },
            new Quote { Text = "Crossposting isn't inherently evil, in the same sense that necrophilia doesn't really hurt anybody. One wonders only whether it's appropriate to the occasion.", Author = "Rick Gordon" },
            new Quote { Text = "The best way to accelerate a Macintosh is at 9.8 m/sec/sec." , Author = "Marcus Dolengo" },
            new Quote { Text = "A distributed system is one in which the failure of a computer you didn't even know existed can render your own computer unusable." , Author = "Leslie Lamport" },
            new Quote { Text = "To err is human - and to blame it on a computer is even more so." , Author = "Robert Orben" },
            new Quote { Text = "A computer once beat me at chess, but it was no match for me at kick boxing." , Author = "Emo Philips" },
            new Quote { Text = "The most overlooked advantage of owning a computer is that if they foul up there's no law against whacking them around a bit." , Author = "Eric Porterfield" },
            new Quote { Text = "A computer is like an Old Testament god, with a lot of rules and no mercy" , Author = "Joseph Campbell" },
            new Quote { Text = "Technology: No Place for Wimps!" , Author = "Scott Adams" },
            new Quote { Text = "Do illiterate people get the full effect of alphabet soup?" , Author = "John Mendoza" },
            // 310

            new Quote { Text = "I would much prefer a government run bureaucracy than a for profit bureaucracy. In the first I am at least a stakeholder. In the latter I'm simply a cost." , Author = "digby in her blog." },
            new Quote { Text = "I'm in shape. Round is a shape." , Author = "George Carlin" },
            new Quote { Text = "If economists were held in the same regard as medical practitioners, our courts would be overwhelmed with malpractice suits" , Author = "unknown" },
            new Quote { Text = "The defense policy of the United States is based on a simple premise: The United States does not start fights. We will never be an aggressor." , Author = "Ronald Reagan" },
            new Quote { Text = "War is wretched beyond description, and only a fool or a fraud could sentimentalize its cruel reality." , Author = "Senator John McCain" },
            new Quote { Text = "Criticism in a time of war is essential to the maintenance of any kind of democratic government." , Author = "Sen. Robert Taft, (R) Ohio" },
            new Quote { Text = "We first fought... in the name of religion, then Communism, and now in the name of drugs and terrorism. Our excuses for global domination always change." , Author = "Serj Tankian" },
            new Quote { Text = "Democracy is not an incident that happens overnight, nor a gift that America can give to the world. It is a culture which needs peace to evolve." , Author = "Shirin Ebadi, Nobel Peace Laureate of Iran" },
            new Quote { Text = "A belligerent state permits itself every such misdeed, every such act of violence, as would disgrace the individual." , Author = "Sigmund Freud" },
            new Quote { Text = "Civilization began the first time an angry person cast a word instead of a rock." , Author = "Sigmund Freud" },
            // 320

            new Quote { Text = "If you live long enough, you'll see that every victory turns into a defeat." , Author = "Simone de Beauvoir" },
            new Quote { Text = "The great error of nearly all studies of war... has been to consider war as an episode in foreign policies, when it is an act of interior politics..." , Author = "Simone Weil" },
            new Quote { Text = "Terrorism is the war of the poor, and war is the terrorism of the rich." , Author = "Sir Peter Ustinov" },
            new Quote { Text = "In modern war there is no such thing as victor and vanquished... There is only a loser, and the loser is mankind." , Author = "U Thant, Burmese UN Secretary General" },
            new Quote { Text = "If you kill one person you are a murderer. If you kill ten people you are a monster. If you kill ten thousand you are a national hero." , Author = "Vassilis Epaminondou" },
            new Quote { Text = "All murderers are punished unless they kill in large numbers and to the sound of trumpets." , Author = "Voltaire" },
            new Quote { Text = "So long as the deceit ran along quiet and monotonous, all of us let ourselves be deceived, abetting it unawares or maybe through cowardice..." , Author = "William Faulkner" },
            new Quote { Text = "The cry has been that when war is declared, all opposition should be hushed. A sentiment more unworthy of a free country could hardly be propagated." , Author = "William Ellery Channing" },
            new Quote { Text = "Necessity is the plea for every infringement of human freedom. It is the argument of tyrants; it is the creed of slaves." , Author = "William Pitt" },
            new Quote { Text = "You can no more win a war than you can win an earthquake." , Author = "Jeanette Rankin" },
            // 330

            new Quote { Text = "Never raise your hands to your kids. It leaves your groin unprotected." , Author = "Red Button" },
            new Quote { Text = "I contend that we are both atheists. I just believe in one fewer god than you do. When you understand why you dismiss all the other possible gods, you will understand why I dismiss yours." , Author = "Stephen Roberts" },
            new Quote { Text = "Any intelligent fool can make things bigger, more complex, and more violent. It takes a touch of genius, and a lot of courage to move in the opposite direction." , Author = "Albert Einstein" },
            new Quote { Text = "Man is certainly stark mad: he cannot make a worm, yet he will make gods by the dozen." , Author = "Michel de Montaigne" },
            new Quote { Text = "Men will never be free until the last king is strangled with the entrails of the last priest." , Author = "Denis Diderot" },
            new Quote { Text = "We, on our side, are praying to Him to give us victory, because we believe we are right; but those on the other side pray to Him, too, for victory, believing they are right. What must He think of us?" , Author = "Abraham Lincoln" },
            new Quote { Text = "All great truths begin as blasphemies." , Author = "George Bernard Shaw" },
            new Quote { Text = "The injury we do and the one we suffer are not weighed in the same scale." , Author = "Aesop" },
            new Quote { Text = "Take only memories; leave nothing but footprints." , Author = "Chief Seattle" },
            new Quote { Text = "They made a wasteland and called it peace." , Author = "Tacitus" },
            // 340

            new Quote { Text = "The law, in its majestic equality, forbids the rich, as well as the poor, to sleep under the bridges, to beg in the streets, and to steal bread." , Author = "Anatole France" },
            new Quote { Text = "The philosopher has never killed any priests, whereas the priest has killed a great many philosophers." , Author = "Denis Diderot" },
            new Quote { Text = "A terrorist is someone who has a bomb but can't afford an air force." , Author = "William Blum" },
            new Quote { Text = "What you do speaks so loud that I cannot hear what you say." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "Disobedience, in the eyes of anyone who has read history, is man's original virtue. It is through disobedience that progress has been made, through disobedience and through rebellion." , Author = "Oscar Wilde" },
            new Quote { Text = "When you philosophically oppose an entire power elite, you cannot help but sound like a conspiracy theorist. Social power is by nature a conspiracy." , Author = "Tom N" },
            new Quote { Text = "Insanity in individuals is something rare; but in groups, parties, nations, and epochs it is the rule." , Author = "Nietzsche" },
            new Quote { Text = "If you talk to God, you are praying. If God talks to you, you have schizophrenia." , Author = "Thomas Szasz" },
            new Quote { Text = "Ah well, then I suppose I shall have to die beyond my means." , Author = "Oscar Wilde, dying words" },
            new Quote { Text = "I agree with the reforms, but I want nothing to change" , Author = "Ion Luca Caragiale" },
            // 350

            new Quote { Text = "Every war when it comes, or before it comes, is represented not as a war but as an act of self-defense against a homicidal maniac." , Author = "George Orwell" },
            new Quote { Text = "You know your god is man-made when he hates all the same people you do." , Author = "[Unknown on Usenet]" },
            new Quote { Text = "Disobedience is the true foundation of liberty. The obedient must be slaves." , Author = "Henry David Thoreau" },
            new Quote { Text = "One man's magic is another man's engineering. Supernatural is a null word." , Author = "Robert Heinlein" },
            new Quote { Text = "We must question the story logic of having an all-knowing all-powerful God, who creates faulty humans, and then blames them for his own mistakes." , Author = "Gene Roddenberry" },
            new Quote { Text = "The trouble with the world is that the stupid are cocksure and the intelligent are full of doubt." , Author = "Bertrand Russell" },
            new Quote { Text = "As with the Christian religion, the worst advertisement for Socialism is its adherents." , Author = "George Orwell" },
            new Quote { Text = "A conservative is a man who is too cowardly to fight and too fat to run." , Author = "Elbert Hubbard" },
            new Quote { Text = "Religion is what keeps the poor from murdering the rich." , Author = "Napoleon" },
            new Quote { Text = "Never be deceived that the rich will allow you to vote away their wealth." , Author = "Lucy Parsons" },
            // 360

            new Quote { Text = "Far too many development shops are run by fools who succeed despite their many failings." , Author = "Brion L. Webster" },
            new Quote { Text = "Religion comprises a system of wishful illusions together with a disavowal of reality, such as we find in an isolated form nowhere else but in amentia, in a state of blissful hallucinatory confusion." , Author = "Sigmund Freud" },
            new Quote { Text = "The ink of the scholar is holier than the blood of the martyr." , Author = "Prophet Muhammad" },
            new Quote { Text = "Which is it, is man one of God's blunders or is God one of man's?" , Author = "Nietzsche" },
            new Quote { Text = "The biggest detractors of communism and socialism always seem to want to embrace the worst excesses of both." , Author = "<Skullhunter>" },
            new Quote { Text = "I never would have agreed to the formulation of the Central Intelligence Agency back in forty-seven, if I had known it would become the American Gestapo." , Author = "Harry S Truman" },
            new Quote { Text = "Men are not punished for their sins, but by them." , Author = "Elbert G Hubbard" },
            new Quote { Text = "I like your Christ; I do not like your Christians. Your Christians are so unlike your Christ." , Author = "Mohandas Gandhi" },
            new Quote { Text = "Patriotism is your conviction that this country is superior to all other countries because you were born in it." , Author = "George Bernard Shaw" },
            new Quote { Text = "You have to stay in shape. My grandmother, she started walking five miles a day when she was 60. She's 97 today and we don't know where she is!", Author = "Ellen DeGeneres." },
            // 370

            new Quote { Text = "The same people that wrote the bible thought the world was flat." , Author = "Unknown" },
            new Quote { Text = "If god created us in his image we have certainly returned the compliment." , Author = "Voltaire" },
            new Quote { Text = "Be happy while you're living, for you're a long time dead." , Author = "Scottish proverb" },
            new Quote { Text = "Work like you don't need the money. Love like you've never been hurt. Dance like nobody's watching." , Author = "Satchel Paige" },
            new Quote { Text = "Be kind; everyone you meet is fighting a hard battle." , Author = "Plato" },
            new Quote { Text = "I'm not into working out.  My philosophy: No pain, no pain." , Author = "Carol Leifer." },
            new Quote { Text = "Capitalism is the astounding belief that the most wickedest of men will do the most wickedest of things for the greatest good of everyone." , Author = "John Maynard Keynes" },
            new Quote { Text = "I distrust those people who know so well what god wants them to do because I notice it always coincides with their own desires." , Author = "Susan B. Anthony" },
            new Quote { Text = "If pigs could vote, the man with the slop bucket would be elected swineherd every time, no matter how much slaughtering he did on the side." , Author = "Orson Scott Card" },
            new Quote { Text = "Now comes the mystery" , Author = "Dying words of Henry Ward Beecher" },
            // 380

            new Quote { Text = "It is poverty to decide that a child must die so that you may live as you wish." , Author = "Mother Teresa" },
            new Quote { Text = "History is an account mostly false, of events mostly unimportant, which are brought about by rulers, mostly knaves, and soldiers, mostly fools." , Author = "Ambrose Bierce" },
            new Quote { Text = "The people who have really made history are the martyrs." , Author = "Aleister Crowley" },
            new Quote { Text = "Laurel and Hardy, that's John and Yoko. And we stand a better chance under that guise because all the serious people like Martin Luther King, Jr. and Kennedy and Gandhi got shot.", Author = "John Lennon" },
            new Quote { Text = "Men who believe absurdities will commit atrocities." , Author = "Voltaire" },
            new Quote { Text = "The nationalist not only does not disapprove of atrocities committed by his own side, but he has a remarkable capacity for not even hearing about them." , Author = "George Orwell" },
            new Quote { Text = "Knowledge, idea, belief stands in the way of wisdom." , Author = "J. Krishnamurthi" },
            new Quote { Text = "If we'd been born where they were born and taught what they were taught, we would believe what they believe." , Author = "A church sign in Northern Ireland" },
            new Quote { Text = "My humble friend, we know not how to live this life which is so short yet seek one that never ends." , Author = "Anatole France" },
            new Quote { Text = "I don't feel good." , Author = "Dying words of Luther Burbank" },
            // 390

            new Quote { Text = "We choose our joys and sorrows long before we experience them." , Author = "Kahlil Gibran" },
            new Quote { Text = "Statistically one hundred percent of the shots you don't take don't go in." , Author = "Wayne Gretsky" },
            new Quote { Text = "On the outskirts of every agony sits some observant fellow who points." , Author = "Virginia Woolf" },
            new Quote { Text = "The fascist state is the corporate state." , Author = "Benito Mussolini" },
            new Quote { Text = "Life is like an overlong drama through which we sit being nagged by the vague memories of having read the reviews." , Author = "John Updike" },
            new Quote { Text = "Each nation knowing it has the only true religion and the only sane system of government, each despising all the others, each an ass and not suspecting it." , Author = "Mark Twain" },
            new Quote { Text = "The nourishment is palatable" , Author = "Dying words of Emily Dickinson" },
            new Quote { Text = "Go on, get out.  Last words are for fools who haven't said enough.", Author = "Dying words of Karl Marx" },
            new Quote { Text = "I still live.", Author = "Dying words of Daniel Webster" },
            new Quote { Text = "Go away... I'm alright.", Author = "Dying words of H.G.Wells" },
            // 400

            #endregion

            #region 401 - 500

            new Quote { Text = "All men are created equal. They are endowed by their creator with certain unalienable rights, among these are life, liberty and the pursuit of happiness." , Author = "Ho Chi Minh as the Democratic Republic of Vietnam was created" },
            new Quote { Text = "If there has to be a blood bath, let's get it over with." , Author = "Ronald Reagan, Vietnam" },
            new Quote { Text = "You will kill ten of our men, and we will kill one of yours, and in the end it will be you who tire of it." , Author = "Ho Chi Minh" },
            new Quote { Text = "I ain't got no quarrel with the Vietcong ... No Vietcong ever called me nigger." , Author = "Muhammad Ali" },
            new Quote { Text = "If you are required to kill someone today, on the promise of a political leader that someone else shall live in peace tomorrow, believe me, you are not only a double murderer, you are a suicide, too." , Author = "Katherine Anne Porter" },
            new Quote { Text = "I spent thirty-three years in the marines, most of my time being a high-class muscle man for big business, for Wall Street and the bankers. In short, I was a racketeer for capitalism." , Author = "General Smedley Butler, Marine" },
            new Quote { Text = "What difference does it make to the dead, the orphans, and the homeless, whether the mad destruction is wrought under the name of totalitarianism or the holy name of liberty and democracy?" , Author = "Mohandas Gandhi" },
            new Quote { Text = "It is not so much the suffering as the senselessness of it that is unendurable." , Author = "Nietzsche" },
            new Quote { Text = "When great changes occur in history, when great principles are involved, as a rule the majority are wrong." , Author = "Eugene V. Debs" },
            new Quote { Text = "Usually when people are sad, they don't do anything. They just cry over their condition. But when they get angry, they bring about a change." , Author = "Malcolm X" },
            // 410

            new Quote { Text = "If we could read the secret history of our enemies, we should find in each man's life sorrow and suffering enough to disarm all hostility." , Author = "Henry Wadsworth Longfellow" },
            new Quote { Text = "Where it is a duty to worship the sun, it is pretty sure to be a crime to examine the laws of heat." , Author = "John Morley" },
            new Quote { Text = "A casual stroll through the lunatic asylum shows that faith does not prove anything." , Author = "Nietzsche" },
            new Quote { Text = "Friends applaud, the Comedy is over." , Author = "Dying words of Ludwig von Beethoven" },
            new Quote { Text = "Humanity without religion is like a serial killer without a chainsaw." , Author = "Unknown" },
            new Quote { Text = "Humanity has advanced, when it has advanced, not because it has been sober, responsible, and cautious, but because it has been playful, rebellious, and immature." , Author = "Tom Robbins" },
            new Quote { Text = "I have seldom met an intelligent person whose views were not narrowed and distorted by religion." , Author = "James Buchanan" },
            new Quote { Text = "Fascism is capitalism in decay." , Author = "Vladimir Ilyich Lenin" },
            new Quote { Text = "Giving money and power to government is like giving whiskey and car keys to teenage boys." , Author = "P. J. O'Rourke" },
            new Quote { Text = "The police are not here to create disorder. They're here to preserve disorder." , Author = "Ex-Chicago Mayor Daley during the 1968 riots" },
            // 420

            new Quote { Text = "We need a common enemy to unite us." , Author = "Condoleezza Rice" },
            new Quote { Text = "I don't know that atheists should be considered citizens, nor should they be considered patriots. This is one nation under God." , Author = "President George Bush" },
            new Quote { Text = "Peace is over rated. Any slave can have peace. Just pick the cotton." , Author = "TheSong" },
            new Quote { Text = "Pain is certain, suffering is optional." , Author = "Buddha" },
            new Quote { Text = "Could a being create the fifty billion galaxies, each with two hundred billion stars, then rejoice in the smell of burning goat flesh?" , Author = "Ron Patterson" },
            new Quote { Text = "The United States is in no sense founded upon the Christian doctrine." , Author = "George Washington Administration Treaty" },
            new Quote { Text = "In the end, we will remember not the words of our enemies, but the silence of our friends." , Author = "Martin Luther King, Jr." },
            new Quote { Text = "You're not to be so blind with patriotism that you can't face reality. Wrong is wrong, no matter who does it or says it." , Author = "Malcolm X" },
            new Quote { Text = "The great nations have always acted like gangsters, and the small nations like prostitutes." , Author = "Stanley Kubrick" },
            new Quote { Text = "The Pope!?! How many divisions has he got?" , Author = "Joseph Stalin" },
            // 430

            new Quote { Text = "Science has done more for the development of western civilization in one hundred years than Christianity did in eighteen hundred years." , Author = "Jeff Burroughs" },
            new Quote { Text = "It is my conviction that killing under the cloak of war is nothing but an act of murder." , Author = "Albert Einstein" },
            new Quote { Text = "Americans used to roar like lions for liberty; now we bleat like sheep for security." , Author = "Norman Vincent Peale" },
            new Quote { Text = "Probably no nation is rich enough to pay for both war and education." , Author = "Braham Flexner" },
            new Quote { Text = "Everybody's worried about stopping terrorism. Well, there's a really easy way; stop participating in it." , Author = "Noam Chomsky" },
            new Quote { Text = "Everyone laughs and cries in the same language." , Author = "dreamslaughter" },
            new Quote { Text = "When you give food to the poor, they call you a saint. When you ask why the poor have no food, they call you a communist." , Author = "Archbishop Helder Camara" },
            new Quote { Text = "I saw a human skull the other day. There was an inscription below it: 'Look long and hard at me, for I was once as you are and you will soon be as I am.'" , Author = "Unknown" },
            new Quote { Text = "Missionaries are perfect nuisances and leave every place worse than they found it." , Author = "Charles Dickens" },
            new Quote { Text = "A coward is a hero with a wife, kids, and a mortgage." , Author = "Marvin Kitman." },
            // 440

            new Quote { Text = "What do the nationalists say about killers punishing murderers and thieves sentencing looters?" , Author = "Kahlil Gibran" },
            new Quote { Text = "The most heinous and the cruelest crimes of which history has record have been committed under the cover of religion or equally noble motives." , Author = "Mohandas Gandhi" },
            new Quote { Text = "Now, my good man, this is no time for making enemies." , Author = "Voltaire, deathbed, when asked to renounce Satan" },
            new Quote { Text = "Isn't it enough to see that a garden is beautiful without having to believe that there are fairies at the bottom of it too?" , Author = "Douglas Adams" },
            new Quote { Text = "I sometimes think that god in creating man somewhat overestimated his ability." , Author = "Oscar Wilde" },
            new Quote { Text = "If English was good enough for Jesus, it's good enough for them Mexicans." , Author = "Texas politician, Spanish as a second language" },
            new Quote { Text = "The first clergyman was the first rascal who met the first fool." , Author = "Voltaire" },
            new Quote { Text = "Democracy is four wolves and a lamb voting on what to have for lunch." , Author = "Ambrose Bierce" },
            new Quote { Text = "No one rules if no one obeys." , Author = "<TaoDo>" },
            new Quote { Text = "Most of the things worth doing in the world had been declared impossible before they were done." , Author = "Louis Brandeis" },
            // 450

            new Quote { Text = "The history of liberty is a history of resistance. The history of liberty is a history of limitations of governmental power, not the increase of it." , Author = "Woodrow Wilson" },
            new Quote { Text = "None are more hopelessly enslaved than those who falsely believe they are free." , Author = "Johann Wolfgang von Goethe" },
            new Quote { Text = "It does me no injury for my neighbor to say there are twenty gods, or no god. It neither picks my pocket nor breaks my leg." , Author = "Thomas Jefferson" },
            new Quote { Text = "All Bibles are man-made." , Author = "Thomas Edison" },
            new Quote { Text = "In nature, there are neither rewards nor punishments; there are consequences." , Author = "Robert G. Ingersoll" },
            new Quote { Text = "We always obeyed the law. Isn't that what you do in America? Even if you don't agree with a law personally, you still obey it. Otherwise life would be chaos." , Author = "Gertrude Scholtz-Klink" },
            new Quote { Text = "I hit him to get his attention. I shot him to calm him down. I killed him to reason with him." , Author = "Henry Rollins" },
            new Quote { Text = "How good bad music and bad reasons sound when we march against an enemy!" , Author = "Nietzsche" },
            new Quote { Text = "The crimes of the U.S. throughout the world have been systematic, constant, clinical, remorseless, and fully documented but nobody cares to talk about them." , Author = "Harold Pinter" },
            new Quote { Text = "How long would authority ... exist, if not for the willingness of the mass to become soldiers, policemen, jailers, and hangmen." , Author = "Emma Goldman" },
            // 460

            new Quote { Text = "You get what anyone gets; you get a lifetime." , Author = "Death, Neil Gaiman Comic Sandman" },
            new Quote { Text = "To be wronged is nothing unless you continue to remember it." , Author = "Confucius" },
            new Quote { Text = "The truth is that there is nothing noble in being superior to somebody else. The only real nobility is in being superior to your former self." , Author = "Whitney Young" },
            new Quote { Text = "If you ever drop your keys into a river of molten lava, let 'em go, because, man, they're gone." , Author = "Jack Handey" },
            new Quote { Text = "All our lauded technological progress, our very civilization, is like the axe in the hand of the pathological criminal." , Author = "Albert Einstein" },
            new Quote { Text = "We hang the petty thieves and appoint the great ones to public office." , Author = "Aesop" },
            new Quote { Text = "In the 1980s capitalism triumphed over communism. In the 1990s it triumphed over democracy." , Author = "David Korten" },
            new Quote { Text = "The corporation is a true Frankenstein's monster, an artificial person run amok, responsible only to its own soulless self." , Author = "William Dugger" },
            new Quote { Text = "Convictions are more dangerous foes of truth than lies." , Author = "Nietzsche" },
            new Quote { Text = "Hain't we got all the fools in town on our side? And ain't that a big enough majority in any town?" , Author = "Mark Twain" },
            // 470

            new Quote { Text = "In matters of conscience, the law of majority has no place." , Author = "Mohandas Gandhi" },
            new Quote { Text = "Why tell me that a man is a fine speaker, if it is not the truth that he is speaking?" , Author = "Thomas Carlyle" },
            new Quote { Text = "In every country and every age, the priest has been hostile to liberty." , Author = "Thomas Jefferson" },
            new Quote { Text = "A celibate clergy is an especially good idea, because it tends to suppress any hereditary propensity toward fanaticism." , Author = "Carl Sagan" },
            new Quote { Text = "I am amazed how many people on this planet are happy and free and never even saw the US constitution." , Author = "<Reason>" },
            new Quote { Text = "Authoritarian government required to speak, is silent. Representative government required to speak, lies with impunity." , Author = "Napoleon" },
            new Quote { Text = "There is always a certain meanness in the argument of conservatism, joined with a certain superiority in its fact." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "When you are right you cannot be too radical; when you are wrong you cannot be too conservative." , Author = "Martin Luther King, Jr." },
            new Quote { Text = "I choose a block of marble and chop off whatever I don't need." , Author = "Francois-Auguste Rodin, when asked how he makes his statues" },
            new Quote { Text = "Like all dreamers, I mistook disenchantment for truth." , Author = "Jean Paul Sartre" },
            // 480

            new Quote { Text = "If you speak the truth, have one foot in the stirrup." , Author = "Turkish proverb" },
            new Quote { Text = "Somehow we find it hard to sell our values, namely that the rich should plunder the poor." , Author = "John Foster Dulles" },
            new Quote { Text = "To sin by silence when they should protest makes cowards of men." , Author = "Abraham Lincoln" },
            new Quote { Text = "Reality is that which, when you stop believing in it, doesn't go away." , Author = "Philip K. Dick" },
            new Quote { Text = "As a child I understood how to give; I have forgotten this grace since I became civilized." , Author = "Ohiyesa, Sioux" },
            new Quote { Text = "Under capitalism, man exploits man. Under communism, it's just the opposite." , Author = "John Kenneth Galbraith" },
            new Quote { Text = "The target suffered a terminal illness before a firing squad in Baghdad." , Author = "Unnamed officer at senate hearing" },
            new Quote { Text = "Those who hate and fight must stop themselves; otherwise it is not stopped." , Author = "Spock, Day of the Dove" },
            new Quote { Text = "Can anything be stupider than that a man has the right to kill me because he lives on the other side of a river and his ruler has a quarrel with mine, though I have not quarreled with him?" , Author = "Blaise Pascal" },
            new Quote { Text = "I was asked to memorize what I did not understand; and, my memory being so good, it refused to be insulted in that manner." , Author = "Aleister Crowley" },
            // 490

            new Quote { Text = "The greatest artists of this world are never puritans, and seldom even ordinarily respectable." , Author = "H. L. Mencken" },
            new Quote { Text = "It is hard to free fools from chains they revere." , Author = "Voltaire" },
            new Quote { Text = "There is no real wealth but the labor of man. Where the mountains are of gold and the valleys of silver, the world would not be one grain of corn the richer; not one comfort would be added to the human race." , Author = "Percy B. Shelley" },
            new Quote { Text = "Foreign aid is when the poor people of a rich country give money to the rich people of a poor country." , Author = "Gary Hart, BC Comic Strip" },
            new Quote { Text = "I don't really miss god, but I sure miss Santa Claus!" , Author = "Courtney Love" },
            new Quote { Text = "Distrust all in whom the impulse to punish is powerful." , Author = "Nietzsche" },
            new Quote { Text = "The keenest sorrow is to recognize ourselves as the sole cause of all our adversities." , Author = "Sophocles" },
            new Quote { Text = "The truth is more important than the facts." , Author = "Frank Lloyd Wright" },
            new Quote { Text = "Every great advance in natural knowledge has involved the absolute rejection of authority." , Author = "Thomas Huxley" },
            new Quote { Text = "The world is divided into people who think they are right." , Author = "Unknown" },
            // 500

            #endregion

            #region 501- 600

            new Quote { Text = "Faith is belief without evidence in what is told by one who speaks without knowledge, of things without parallel." , Author = "Ambrose Bierce" },
            new Quote { Text = "My opinions may have changed, but not the fact that I am right." , Author = "Ashleigh Brilliant" },
            new Quote { Text = "Pity the warrior that kills all his foe." , Author = "Star Trek" },
            new Quote { Text = "Honolulu, it's got everything.  Sand for the children, sun for the wife, and sharks for the wife's mother." , Author = "Ken Dodd." },
            new Quote { Text = "Every day people are straying away from the church and going back to god." , Author = "Lenny Bruce" },
            new Quote { Text = "A tyrant is always stirring up some war or other, in order that the people may require a leader." , Author = "Plato" },
            new Quote { Text = "War is an instrument entirely insufficient toward redressing wrong; and multiplies, instead of indemnifying losses." , Author = "Thomas Jefferson" },
            new Quote { Text = "I do not feel obliged to believe that the same god who has endowed us with sense, reason, and intellect has intended us to forgo their use." , Author = "Galileo Galilei" },
            new Quote { Text = "The wise man will love; all others will desire." , Author = "Afranius" },
            new Quote { Text = "I've always wanted to be somebody, but I should have been more specific." , Author = "George Carlin" },
            // 510

            new Quote { Text = "Christianity makes suffering contagious." , Author = "Nietzsche" },
            new Quote { Text = "May your fondest wish be granted." , Author = "Traditional Chinese curse" },
            new Quote { Text = "Truth is stranger than fiction, but it is because fiction is obliged to stick to possibilities; truth isn't." , Author = "Mark Twain" },
            new Quote { Text = "The exact contrary of what is generally believed is often the truth." , Author = "Jean de la Bruyère" },
            new Quote { Text = "Life is too short to waste in critical peep or cynic bark, quarrel or reprimand: It will soon be dark." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "Believe those who are seeking the truth; doubt those who find it." , Author = "Andre Gide" },
            new Quote { Text = "That's not a lie, it's a terminological inexactitude." , Author = "Alexander Haig" },
            new Quote { Text = "If one acknowledges a group or a nation willing to commit atrocities, then one must also acknowledges the existence of a nation willing to commit atrocities to blame on the first nation." , Author = "Michael Rivero" },
            new Quote { Text = "He who fights with monsters might take care lest he thereby become a monster. For if you gaze for long into an abyss, the abyss gazes also into you." , Author = "Nietzsche" },
            new Quote { Text = "It is better to be feared than loved, if you cannot be both." , Author = "Niccolo Machiavelli" },
            // 520

            new Quote { Text = "Whenever I hear anyone arguing for slavery, I feel a strong impulse to see it tried on him personally." , Author = "Abraham Lincoln" },
            new Quote { Text = "I prayed for twenty years but received no answer until I prayed with my legs." , Author = "Frederick Douglass, escaped slave" },
            new Quote { Text = "So far as I can remember, there is not one word in the Gospels in praise of intelligence." , Author = "Bertrand Russel" },
            new Quote { Text = "When encountering a new philosophy or religion, do not convert, but rather assimilate." , Author = "Shawn Mikula" },
            new Quote { Text = "At the risk of seeming ridiculous, let me say that the true revolutionary is guided by great feelings of love. It is impossible to think of a genuine revolutionary lacking this quality." , Author = "Ernesto 'Che' Guevara" },
            new Quote { Text = "The only thing necessary for the triumph of evil is for good men to do nothing." , Author = "Edmund Burke" },
            new Quote { Text = "The citizen who sees his society's democratic clothes being worn out and does not cry it out, is not a patriot, but a traitor." , Author = "Mark Twain" },
            new Quote { Text = "The Christian resolution to find the world ugly and bad has made the world ugly and bad." , Author = "Nietzsche" },
            new Quote { Text = "The multitude of books is a great evil. There is no limit to this fever for writing." , Author = "Martin Luther" },
            new Quote { Text = "If the doctor told me I had only six minutes to live, I'd type a little faster." , Author = "Isaac Asimov" },
            // 530

            new Quote { Text = "The modern conservative is engaged in one man's oldest exercises in moral philosophy; that is the search for a superior moral justification for selfishness." , Author = "John K. Galbraith" },
            new Quote { Text = "Conservatives are not necessarily stupid, but most stupid people are conservatives." , Author = "John Stuart Mill" },
            new Quote { Text = "It may be that our role on this planet is not to worship god, but to create him." , Author = "Arthur C. Clarke" },
            new Quote { Text = "In order to learn, one must change one's mind." , Author = "Orson Scott Card" },
            new Quote { Text = "Every anarchist is a baffled dictator." , Author = "Benito Mussolini" },
            new Quote { Text = "Everyone's values are defined by what they will tolerate when it is done to others." , Author = "William Greider" },
            new Quote { Text = "Patriotism is the virtue of the vicious." , Author = "Oscar Wilde" },
            new Quote { Text = "Do not do an immoral thing for moral reasons." , Author = "Thomas Hardy" },
            new Quote { Text = "If fifty million people believe a foolish thing, it is still a foolish thing." , Author = "Anatole France" },
            new Quote { Text = "There must be more to life than having everything." , Author = "Maurice Sendak" },
            // 540

            new Quote { Text = "Knowledge comes, but wisdom lingers." , Author = "Alfred, Lord Tennyson" },
            new Quote { Text = "He who knows nothing is closer to the truth than he whose mind is filled with falsehoods and errors." , Author = "Thomas Jefferson" },
            new Quote { Text = "I had a lover's quarrel with the world." , Author = "Robert Frost" },
            new Quote { Text = "Written laws are like spider's webs; they will catch, it is true, the weak and poor, but would be torn in pieces by the rich and powerful." , Author = "Anacharsis" },
            new Quote { Text = "Computers are useless. They can only give you answers." , Author = "Pablo Picasso" },
            new Quote { Text = "You simply cannot hang a millionaire in America." , Author = "Bourke Cockran" },
            new Quote { Text = "We must be willing to let go of the life we have planned, so as to have the life that is waiting for us." , Author = "Joseph Campbell" },
            new Quote { Text = "When the president does it that means it is not illegal." , Author = "Richard Nixon" },
            new Quote { Text = "War is hell and all that, but it has a good deal to recommend it. It wipes out all the small nuisances of peacetime." , Author = "Ian Hay" },
            new Quote { Text = "Patriotism is the willingness to kill and be killed for trivial reasons." , Author = "Bertrand Russell" },
            // 550

            new Quote { Text = "If there was a god, he wouldn't let a guy walk right up and shoot you in the face now would he? That's right, now you get the picture. Truth burns doesn't it?" , Author = "Henry Rollins" },
            new Quote { Text = "Gentlemen, you can't fight in here! This is the War Room!" , Author = "Dr. Strangelove" },
            new Quote { Text = "I know of no crime that has not been defended by the church, in one form or other. The church is not a pioneer; it accepts a new truth, last of all, and only when denial has become useless." , Author = "Robert G. Ingersoll" },
            new Quote { Text = "In general the art of government consists in taking as much money as possible from one class of citizens to give to the other." , Author = "Voltaire" },
            new Quote { Text = "A nation is a society united by a delusion about its ancestry and by common hatred of its neighbors." , Author = "William R. Inge" },
            new Quote { Text = "Cast aside those who liken godliness to whimsy and who try to combine their greed for wealth with their desire for a happy afterlife." , Author = "Kahlil Gibran" },
            new Quote { Text = "If we do not like the world the way it is, then it is because we are not okay the way we are." , Author = "deeshan" },
            new Quote { Text = "Your every decision conspires to make this moment happen." , Author = "Christi Philpott" },
            new Quote { Text = "Yes, my friends, I too am prepared to die for a cause, but there is no cause for which I am prepared to kill." , Author = "Mohandas Gandhi" },
            new Quote { Text = "Experience is a hard teacher because she gives the test first, the lesson afterwards." , Author = "Vernon Saunders Law" },
            // 560

            new Quote { Text = "It is your business, when the wall next door catches fire." , Author = "Horace" },
            new Quote { Text = "Once you have seen certain things, you can't un-see them, and seeing nothing is as political an act as seeing something." , Author = "Arundhati Roy" },
            new Quote { Text = "The first half of our life is ruined by our parents and the second half by our children." , Author = "Clarence Darrow." },
            new Quote { Text = "Science is always discovering odd scraps of magical wisdom and making a tremendous fuss about its cleverness." , Author = "Aleister Crowley" },
            new Quote { Text = "They said I was the greatest pitcher they ever saw; I couldn't understand why they couldn't give me no justice." , Author = "Satchel Paige" },
            new Quote { Text = "A conservative government is an organized hypocrisy." , Author = "Benjamin Disraeli" },
            new Quote { Text = "In a time of universal deceit, telling the truth is a revolutionary act." , Author = "George Orwell" },
            new Quote { Text = "Think my friends! You adulate a stone as Vishnu but you cannot see God in a fellow man." , Author = "Sankaracharya" },
            new Quote { Text = "The total absence of humor in the Bible is one of the most singular things in all literature." , Author = "Alfred North Whitehead" },
            new Quote { Text = "All I know is that I am not a Marxist." , Author = "Karl Marx" },
            // 570

            new Quote { Text = "There is enough for man's need but not for man's greed." , Author = "Mohandas Gandhi" },
            new Quote { Text = "Before you speak, ask yourself is it kind, is it necessary, is it true, does it improve on the silence?" , Author = "Shirdi Sai Bab" },
            new Quote { Text = "Everything of importance has been said before by somebody who did not discover it." , Author = "Alfred North Whitehead" },
            new Quote { Text = "I object to violence because when it appears to do good, the good is only temporary; the evil it does is permanent." , Author = "Mohandas Gandhi" },
            new Quote { Text = "Truth is for the minority." , Author = "Baltasar Gracián" },
            new Quote { Text = "The color of the skin makes no difference. What is good and just for one is good and just for the other. And the Great Spirit made all men brothers." , Author = "White Shield, Arikara" },
            new Quote { Text = "The reasonable man adjusts himself to the world, the unreasonable one persists in trying to adapt the world to himself; therefore all progress depends on the unreasonable man." , Author = "George Bernard Shaw" },
            new Quote { Text = "I did not know how to say goodbye. It was harder still, when I refused to say it." , Author = "Native American saying" },
            new Quote { Text = "Never was anything great achieved without danger." , Author = "Niccolo Machiavelli" },
            new Quote { Text = "Those who see and feel beyond illusion have acquired a far greater gift than could ever be derived from studying scripture and philosophy books, for these were meant only to guide the blind." , Author = "Shawn Mikula" },
            // 580

            new Quote { Text = "If you understand everything, you must be misinformed." , Author = "Japanese Proverb" },
            new Quote { Text = "Theology is never any help; it is searching in a dark cellar at midnight for a black cat that isn't there. Theologians can persuade themselves of anything." , Author = "Robert Heinlein" },
            new Quote { Text = "This monkey mythology of Darwin is the cause of permissiveness, promiscuity, prophylactics, perversions, pregnancies, abortions, pollution, poisoning and proliferation of crimes of all types." , Author = "Judge Braswell Dean" },
            new Quote { Text = "The state has not the right to leave every man free to profess and embrace whatever religion he may desire." , Author = "Pope Pius IX" },
            new Quote { Text = "Government is actually the worst failure of civilized man. There has never been a really good one, and even those that are most tolerable are arbitrary, cruel, grasping and unintelligent." , Author = "H. L. Mencken" },
            new Quote { Text = "It's not what you don't know that hurts you. It's what you know that just isn't so." , Author = "Satchel Paige" },
            new Quote { Text = "We've got to pause and ask ourselves, how much clean air do we need?" , Author = "Lee Iacocca" },
            new Quote { Text = "It has become appallingly obvious that our technology has exceeded our humanity." , Author = "Albert Einstein" },
            new Quote { Text = "The difference between our decadence and the Russians' is that while theirs is brutal, ours is apathetic." , Author = "James Thurber" },
            new Quote { Text = "I do not read advertisements. I would spend all of my time wanting things." , Author = "Franz Kafka" },
            // 590

            new Quote { Text = "Don't join the book burners." , Author = "Dwight D. Eisenhower" },
            new Quote { Text = "To date, despite the efforts of millions of true believers to support this myth, there is no more evidence for the Judeo-Christian god than any of the gods on Mount Olympus." , Author = "Joseph Daleiden" },
            new Quote { Text = "Free from desire, you realize the mystery. Caught in desire, you see only the manifestations." , Author = "Tao Te Ching" },
            new Quote { Text = "if you keep doing what you've always done, you'll keep getting what you've always gotten." , Author = "Jim Rohn" },
            new Quote { Text = "Few people are capable of expressing with equanimity opinions which differ from the prejudices of their social environment. Most people are even incapable of forming such opinions." , Author = "Albert Einstein" },
            new Quote { Text = "Everything should be made as simple as possible, but not simpler." , Author = "Albert Einstein" },
            new Quote { Text = "Our scientific power has outrun our spiritual power. We have guided missiles and misguided men." , Author = "Martin Luther King, Jr." },
            new Quote { Text = "We could have saved the Earth but we were too damned cheap." , Author = "Kurt Vonnegut" },
            new Quote { Text = "Irrationally held truths may be more harmful than reasoned errors." , Author = "Thomas Huxley" },
            new Quote { Text = "It is a government of the people by the people for the people no longer; it is a government of corporations by corporations for corporations." , Author = "Rutherford B. Hayes" },
            // 600

            #endregion

            #region 601-700

            new Quote { Text = "In all affairs, it's a healthy thing now and then to hang a question mark on the things you have long taken for granted." , Author = "Bertrand Russell" },
            new Quote { Text = "Religion is not merely the opium of the masses; it's the cyanide." , Author = "Tom Robbins" },
            new Quote { Text = "Nothing overshadows truth so much as authority." , Author = "Leon Battista Alberti" },
            new Quote { Text = "In Christianity, neither morality nor religion comes into contact with reality at any point." , Author = "Nietzsche" },
            new Quote { Text = "A language is a dialect with an army and a navy." , Author = "Max Weinreich" },
            new Quote { Text = "It is dangerous to be right in matters on which the established authorities are wrong." , Author = "Voltaire" },
            new Quote { Text = "Beware of the man whose god is in the skies." , Author = "George Bernard Shaw" },
            new Quote { Text = "Almost all absurdity of conduct arises from the imitation of those whom we cannot resemble." , Author = "Samuel Johnson" },
            new Quote { Text = "Turn over the pages of history and read the damning record of the church's opposition to every advance in every field of science." , Author = "Upton Sinclair" },
            new Quote { Text = "Don't try to teach a pig to sing, it can't be done and it only ticks off the pig." , Author = "Robert Heinlein" },
            // 610

            new Quote { Text = "Form no covetous desire, so that the demon of greediness may not deceive thee, and the treasure of the world may not be tasteless to thee." , Author = "Zoroaster" },
            new Quote { Text = "The more laws and order are made prominent, the more thieves and robbers there will be." , Author = "Lao Tsu" },
            new Quote { Text = "People with virtue must speak out; People who speak are not all virtuous." , Author = "Confucius" },
            new Quote { Text = "One death is a tragedy. A million deaths is a statistic." , Author = "Josef Stalin" },
            new Quote { Text = "Prohibition goes beyond reason in that it attempts to control a man's appetite through legislation. A prohibition law strikes a blow at the very principles this country was founded upon." , Author = "Abraham Lincoln" },
            new Quote { Text = "When liberty is taken away by force it can be restored by force. When it is relinquished voluntarily by default, it can never be recovered." , Author = "Dorothy Thompson" },
            new Quote { Text = "Problems cannot be solved at the same level of awareness that created them." , Author = "Albert Einstein" },
            new Quote { Text = "We can often do more for other men by trying to correct our own faults than by trying to correct theirs." , Author = "Francois Fenelon" },
            new Quote { Text = "News is what someone wants to suppress. Everything else is advertising." , Author = "Ex-NBC news president Rubin Frank" },
            new Quote { Text = "When women are depressed they either eat or go shopping. Men invade another country." , Author = "Elayne Boosler" },
            // 620

            new Quote { Text = "To use the term blind faith, is to use an adjective needlessly." , Author = "Julian Ruck" },
            new Quote { Text = "The establishment of Christianity arrested the normal development of the physical sciences for over fifteen hundred years." , Author = "Andrew Dickson White" },
            new Quote { Text = "It is right noble to fight with wickedness and wrong; the mistake is in supposing that spiritual evil can be overcome by physical means." , Author = "Lydia Maria Child" },
            new Quote { Text = "Nothing except a battle lost can be half as melancholy as a battle won." , Author = "Duke of Wellington" },
            new Quote { Text = "All warfare is based on deception." , Author = "Sun tzu" },
            new Quote { Text = "Nothing brings people together more, than mutual hatred." , Author = "Henry Rollins" },
            new Quote { Text = "Just as a picture is drawn by an artist, surroundings are created by the activities of the mind." , Author = "Buddha" },
            new Quote { Text = "The best way to make children good is to make them happy." , Author = "Oscar Wilde" },
            new Quote { Text = "The minority, the ruling class at present, has the schools and press, usually the Church as well under its thumb. This enables it to organize and sway the emotions of the masses, and make its tool of them." , Author = "Albert Einstein" },
            new Quote { Text = "All civilization has from time to time become a thin crust over a volcano of revolution." , Author = "Havelock Ellis" },
            // 630

            new Quote { Text = "Outside of the killings, Washington has one of the lowest crime rates in the country." , Author = "Marion Barry, former mayor Washington D.C." },
            new Quote { Text = "When I told the people of Northern Ireland that I was an atheist, a woman in the audience stood up and said, 'Yes, but is it the God of the Catholics or the God of the Protestants in whom you don't believe?'" , Author = "Quentin Crisp" },
            new Quote { Text = "Whatever the natural cause, sin is the true cause of all earthquakes." , Author = "John Wesley" },
            new Quote { Text = "Anyone who has two shirts when someone has none is not a Christian." , Author = "Lenny Bruce" },
            new Quote { Text = "Generosity is not giving me that which I need more than you do, but it is giving me that which you need more than I do." , Author = "Kahlil Gibran" },
            new Quote { Text = "You exist only in what you do." , Author = "Federico Fellini" },
            new Quote { Text = "All truth passes through three stages. First, it is ridiculed. Second, it is violently opposed. Third, it is accepted as being self-evident." , Author = "Arthur Schopenhauer" },
            new Quote { Text = "Kindness is more important than wisdom, and the recognition of this is the beginning of wisdom." , Author = "Theodore Isaac Rubin" },
            new Quote { Text = "You can't say civilizations don't advance, because they kill you in a new way in each war." , Author = "Will Rogers" },
            new Quote { Text = "In order to be an immaculate member of a flock of sheep, one must above all be a sheep oneself." , Author = "Albert Einstein" },
            // 640

            new Quote { Text = "The church tries to save sinners, but science seeks to stop their manufacture." , Author = "Elbert Hubbard" },
            new Quote { Text = "I can't embrace a male god who has persecuted female sexuality throughout the ages; and that persecution still goes on today, all over the world." , Author = "Amanda Donohoe" },
            new Quote { Text = "Any fool can make a rule, and any fool will mind it." , Author = "Henry David Thoreau" },
            new Quote { Text = "Pontius Pilate was the first great censor, and Jesus Christ the first great victim of censorship." , Author = "Ben Lindsay" },
            new Quote { Text = "We are what we think. All that we are arises with our thoughts. With our thoughts, we make the world." , Author = "Buddha" },
            new Quote { Text = "I thought dying for your country was the worst thing that could happen to you. I think killing for your country can be a lot worse; because that's the memory that haunts." , Author = "Bob Kerry told to The New York Times" },
            new Quote { Text = "It is lamentable, that to be a good patriot one must become the enemy of the rest of mankind." , Author = "Voltaire" },
            new Quote { Text = "Contraction of theological influence has at once been the best measure, and the essential condition of intellectual advance." , Author = "William H. Lecky" },
            new Quote { Text = "Isn't killing people in the name of God a pretty good definition of insanity?" , Author = "Arthur C. Clarke" },
            new Quote { Text = "Talent hits a target no one else can hit; Genius hits a target no one else can see." , Author = "Arthur Schopenhauer" },
            // 650

            new Quote { Text = "Oh Mortal Man, is there nothing you cannot be made to believe?" , Author = "Adam Weishaupt, Co-founder New World Order" },
            new Quote { Text = "There are three truths: my truth, your truth, and the truth." , Author = "Chinese proverb" },
            new Quote { Text = "People only see what they are prepared to see." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "Lying is done with words and also with silence." , Author = "Adrienne Rich" },
            new Quote { Text = "If a man would follow, today, the teachings of the Old Testament, he would be a criminal. If he would follow strictly the teachings of the New, he would be insane." , Author = "Robert G. Ingersoll" },
            new Quote { Text = "The man who accumulates, whether money or knowledge, can never be free." , Author = "J. Krishnamurthi" },
            new Quote { Text = "There is a tragic clash between truth and the world. Pure undistorted truth burns up the world." , Author = "Nikolay Berdyayev" },
            new Quote { Text = "Just drive down that road, until you get blown up." , Author = "General George Patton, reconnaissance troops" },
            new Quote { Text = "I never advocated war except as a means of peace." , Author = "Ulysses S. Grant" },
            new Quote { Text = "If you pray for rain long enough, it eventually does fall. If you pray for floodwaters to abate, they eventually do. The same happens in the absence of prayers." , Author = "Steve Allen" },
            // 660

            new Quote { Text = "Spiritual maturity is a lifelong process of replacing lies with truth." , Author = "Kurt Bruner" },
            new Quote { Text = "I was under medication when I made the decision to burn the tapes." , Author = "Richard Nixon" },
            new Quote { Text = "Freedom is not something that anybody can be given, freedom is something people take." , Author = "James Baldwin" },
            new Quote { Text = "The public is wonderfully tolerant. It forgives everything except genius." , Author = "Oscar Wilde" },
            new Quote { Text = "Intellectuals solve problems; geniuses prevent them." , Author = "Albert Einstein" },
            new Quote { Text = "Acceptance without proof is the fundamental characteristic of Western religion, rejection without proof is the fundamental characteristic of Western science." , Author = "Gary Zukav" },
            new Quote { Text = "How can you make a revolution without executions?" , Author = "Lenin on hearing that the death penalty had been abolished by the Soviet" },
            new Quote { Text = "True and false are attributes of speech, not of things. And where speech is not, there is neither truth nor falsehood." , Author = "Thomas Hobbes" },
            new Quote { Text = "Do you love your creator? Love your fellow beings first." , Author = "Prophet Muhammad" },
            new Quote { Text = "Laws are silent in time of war." , Author = "Cicero" },
            // 670

            new Quote { Text = "I shall be an autocrat: that's my trade. And the good Lord will forgive me: that's his." , Author = "Empress Catherine the Great" },
            new Quote { Text = "Man was born free, and everywhere he is in chains." , Author = "Rousseau" },
            new Quote { Text = "Never go to sleep when your meat is on the fire." , Author = "Pueblo" },
            new Quote { Text = "A treatise upon human nature: It is not contrary to reason to prefer the destruction of the whole world to the scratching of my finger." , Author = "David Hume" },
            new Quote { Text = "You can't step twice into the same river." , Author = "Heraclitus" },
            new Quote { Text = "You should never wear your best trousers when you go out to fight for freedom and liberty." , Author = "Henrik Ibsen" },
            new Quote { Text = "Necessity never made a good bargain." , Author = "Ben Franklin" },
            new Quote { Text = "You shall find out how salt is the taste of another man's bread, and how hard is the way up and down another man's stairs." , Author = "Dante" },
            new Quote { Text = "You'll never have a quiet world till you knock the patriotism out of the human race." , Author = "George Bernard Shaw" },
            new Quote { Text = "This is very true; for my words are my own, and my actions are my ministers." , Author = "Charles II" },
            // 680

            new Quote { Text = "Sometimes a scream is better than a thesis." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "There are very few monsters who warrant the fear we have of them." , Author = "Andre Gide" },
            new Quote { Text = "Whoever controls the media, the images, controls the culture." , Author = "Allen Ginsberg" },
            new Quote { Text = "Listen or your tongue will keep you deaf." , Author = "Native American saying" },
            new Quote { Text = "One-tenth of the folks run the world. One-tenth watch them run it, and the other eighty percent don't know what the hell's going on." , Author = "Jake Simmons" },
            new Quote { Text = "An empty stomach is not a good political advisor." , Author = "Albert Einstein" },
            new Quote { Text = "Religion is the end of love and honesty, the beginning of confusion; faith is a colorful hope or fear, the origin of folly." , Author = "Tao Te Ching" },
            new Quote { Text = "Why do we kill people who are killing people to show that killing people is wrong?" , Author = "Holly Near" },
            new Quote { Text = "If you give me six lines written by the hand of the most honest of men, I will find something in them which will hang him." , Author = "Cardinal Richelieu" },
            new Quote { Text = "Only a fool tests the depth of the water with both feet." , Author = "African proverb" },
            // 690

            new Quote { Text = "Democracy is the recurrent suspicion that more than half of the people are right more than half of the time." , Author = "Elwyn B. White" },
            new Quote { Text = "The more I study religions the more I am convinced that man never worshipped anything but himself." , Author = "Sir R. F. Burton" },
            new Quote { Text = "We are ensnared by the wisdom of the serpent; we are set free by the foolishness of God." , Author = "Saint Augustine" },
            new Quote { Text = "We live in our desires rather than in our achievements." , Author = "George Moore" },
            new Quote { Text = "Wherever there is great property, there is great inequality, for one very rich man; there must be at least five hundred poor." , Author = "Adam Smith" },
            new Quote { Text = "When a government lasts a long while, it deteriorates by insensible degrees. Republics end through luxury, monarchies through poverty." , Author = "Montesquieu" },
            new Quote { Text = "The cardinal doctrine of a fanatic's creed is that his enemies are the enemies of God." , Author = "Andrew Dickson White" },
            new Quote { Text = "Society in every state is a blessing, but government, even in its best stage, is but a necessary evil; in its worst stage, an intolerable one." , Author = "Thomas Paine" },
            new Quote { Text = "The supreme art of war is to subdue the enemy without fighting." , Author = "Sun tzu" },
            new Quote { Text = "A foolish consistency is the hobgoblin of little minds, adored by little statesmen and philosophers and divines." , Author = "Ralph Waldo Emerson" },
            // 700

            #endregion

            #region 701 - 800

            new Quote { Text = "Truthful words are not beautiful; beautiful words are not truthful. Good words are not persuasive; persuasive words are not good." , Author = "Lao tzu" },
            new Quote { Text = "Oh, how bitter a thing is to look through another man's eye." , Author = "William Shakespeare" },
            new Quote { Text = "Know all and you will pardon all." , Author = "Thomas à Kempis" },
            new Quote { Text = "I am sufficiently proud of my knowing something to be modest about my not knowing everything." , Author = "Vladimir Nabokov" },
            new Quote { Text = "All natural institutions of churches, whether Jewish, Christian, or Turkish, appear to me no other than human inventions, set up to terrify and enslave mankind, and monopolize power and profit." , Author = "Thomas Paine" },
            new Quote { Text = "They that die by famine die by inches." , Author = "Matthew Henry" },
            new Quote { Text = "In law a man is guilty when he violates the rights of another. In ethics he is guilty if he only thinks of doing so." , Author = "Immanuel Kant" },
            new Quote { Text = "There is no sport in hate when all the rage is on one side." , Author = "Percy B. Shelley" },
            new Quote { Text = "Except as its clown and jester, society does not encourage individuality, and the State abhors it." , Author = "Bernard Berenson" },
            new Quote { Text = "Everywhere is walking distance if you have the time." , Author = "Steven Wright" },
            // 710

            new Quote { Text = "You must ask your neighbor if you shall live in peace." , Author = "John Clark" },
            new Quote { Text = "It is true that liberty, so precious, must be rationed." , Author = "Nikolai Lenin" },
            new Quote { Text = "It would now be technically possible to unify the world, abolish war and poverty altogether, if men desired their own happiness more than the misery of their enemies." , Author = "Bertrand Russel" },
            new Quote { Text = "Most men lead lives of quiet desperation and go to the grave with the song still in them." , Author = "Henry David Thoreau" },
            new Quote { Text = "I refuse to be labeled immoral merely because I am godless." , Author = "Peter Walker" },
            new Quote { Text = "Art is dangerous. It is one of the attractions: when it ceases to be dangerous, you don't want it." , Author = "Duke Ellington" },
            new Quote { Text = "Suppose you were an idiot, and suppose you were a member of congress; but I repeat myself." , Author = "Mark Twain" },
            new Quote { Text = "Know thy enemy and know thy self and you will win a hundred battles." , Author = "Sun tzu" },
            new Quote { Text = "Life is like a game of cards. The hand that is dealt you represents determinism; the way you play it is free will." , Author = "Jawaharlal Nehru" },
            new Quote { Text = "The optimist proclaims that we live in the best of all possible worlds; and the pessimist fears this is true." , Author = "James Branch Cabell" },
            // 720

            new Quote { Text = "Peace is only possible if men cease to place their happiness in the possession of things which cannot be shared." , Author = "Julien Benda" },
            new Quote { Text = "It may be necessary temporarily to accept a lesser evil, but one must never label a necessary evil as good." , Author = "Margaret Mead" },
            new Quote { Text = "Silence is one of the hardest arguments to refute." , Author = "Josh Billings" },
            new Quote { Text = "You can't wake a person who is pretending to be asleep." , Author = "Native Proverb" },
            new Quote { Text = "I have often regretted my speech, never my silence." , Author = "Xenocrates" },
            new Quote { Text = "Never does nature say one thing and wisdom another." , Author = "Juvenal" },
            new Quote { Text = "He who will not reason is a bigot; he who cannot is a fool; and he who dares not is a slave." , Author = "William Drummond" },
            new Quote { Text = "The quickest way of ending a war is to lose it." , Author = "George Orwell" },
            new Quote { Text = "Truth always lags behind, limping along on the arm of Time." , Author = "Baltasar Gracián" },
            new Quote { Text = "Nothing unites the English like war. Nothing divides them like Picasso." , Author = "Hugh Mills" },
            // 730

            new Quote { Text = "...as hollow as the o in god..." , Author = "Marilyn Manson" },
            new Quote { Text = "War: first, one hopes to win; then one expects the enemy to lose; then, one is satisfied that he too is suffering; in the end, one is surprised that everyone has lost." , Author = "Karl Kraus" },
            new Quote { Text = "It is better to be generous than just. It is sometimes better to sympathize instead of trying to understand." , Author = "Pierre Lecompte de Nouy" },
            new Quote { Text = "The more you own, the more it owns you." , Author = "Henry Rollins" },
            new Quote { Text = "Money often costs too much." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "Nothing is more surprising than the easiness with which the many are governed by the few." , Author = "David Hume" },
            new Quote { Text = "And the little screaming fact that sounds through all history: repression works only to strengthen and knit the repressed." , Author = "John Steinbeck" },
            new Quote { Text = "We are condemned to kill time: thus we die bit by bit." , Author = "Octavio Paz" },
            new Quote { Text = "Do not seek to follow in the footsteps of the wise. Seek what they sought." , Author = "Basho" },
            new Quote { Text = "By trying we can easily learn to endure adversity; another man's, I mean." , Author = "Mark Twain" },
            // 740

            new Quote { Text = "Give to every other human being every right you claim for yourself." , Author = "Robert G. Ingersoll" },
            new Quote { Text = "While the word is yet unspoken, you are master of it; when once it is spoken, it is master of you." , Author = "Arab proverb" },
            new Quote { Text = "Twenty years from now you will be more disappointed by the things that you didn't do than by the ones you did do." , Author = "Samuel Clemens" },
            new Quote { Text = "Ignorance is always afraid of change." , Author = "Jawaharlal Nehru" },
            new Quote { Text = "Before we blame, we should first see if we can excuse." , Author = "G. C. Lichtenberg" },
            new Quote { Text = "Don't speak unless you can improve on the silence." , Author = "Spanish proverb" },
            new Quote { Text = "I would have made a good pope." , Author = "Richard Nixon" },
            new Quote { Text = "In politics, stupidity is not a handicap." , Author = "Napoleon" },
            new Quote { Text = "The purpose of law is to prevent the strong from always having their way." , Author = "Ovid" },
            new Quote { Text = "Time is a great teacher, but unfortunately it kills all its pupils." , Author = "Hector Berlioz" },
            // 750

            new Quote { Text = "A man who is afraid will do anything." , Author = "Jawaharlal Nehru" },
            new Quote { Text = "Heresy is a cradle; orthodoxy a coffin." , Author = "Robert G. Ingersoll" },
            new Quote { Text = "Each of us is confined to a world of our own making." , Author = "Shawn Mikula" },
            new Quote { Text = "Democracy used to be a good thing, but now it has gotten into the wrong hands." , Author = "Jessie Helms" },
            new Quote { Text = "No one has ever had an idea in a dress suit." , Author = "Sir Frederick G. Banting" },
            new Quote { Text = "Without censorship, things can get terribly confused in the public mind." , Author = "General William Westmoreland" },
            new Quote { Text = "Strange is our situation here upon Earth." , Author = "Albert Einstein" },
            new Quote { Text = "Until the infallibility of human judgment shall have been proved to me, I shall persist in demanding the abolition of the death penalty." , Author = "Marquis de Lafayette" },
            new Quote { Text = "If you don't know where you're going, any road will get you there." , Author = "Ancient Chinese Proverb" },
            new Quote { Text = "Opportunities multiply as they are seized." , Author = "Sun tzu" },
            // 760

            new Quote { Text = "Real knowledge is to know the extent of one's ignorance." , Author = "Confucius" },
            new Quote { Text = "As far as the laws of mathematics refer to reality, they are not certain, and as far as they are certain, they do not refer to reality." , Author = "Albert Einstein" },
            new Quote { Text = "One's mind, once stretched by a new idea, never regains its original dimensions." , Author = "Oliver Wendell Holmes" },
            new Quote { Text = "It is not easy to find happiness in ourselves; it is not possible to find it elsewhere." , Author = "Agnes Repplier" },
            new Quote { Text = "Being deeply loved by someone gives you strength; loving someone deeply gives you courage." , Author = "Lao tzu" },
            new Quote { Text = "The world is too dangerous to live in, not because of the people who do evil, but because of the people who sit and let it happen." , Author = "Albert Einstein" },
            new Quote { Text = "Beliefs are what divide people. Doubt unites them." , Author = "Peter Ustinov" },
            new Quote { Text = "Wisdom is knowing what to do next. Virtue is doing it." , Author = "David Starr Jordan" },
            new Quote { Text = "The liar's punishment is not in the least that he is not believed, but that he cannot believe anyone else." , Author = "George Bernard Shaw" },
            new Quote { Text = "Whatever you do will be insignificant, but it is very important that you do it." , Author = "Mohandas Gandhi" },
            // 770

            new Quote { Text = "You can't have everything. Where would you put it?" , Author = "Steven Wright" },
            new Quote { Text = "The way to find what the mainstream will do tomorrow is to associate with the lunatic fringe today." , Author = "Jean-Louis Gassee" },
            new Quote { Text = "A jury consists of twelve persons chosen to decide who has the better lawyer." , Author = "Robert Frost" },
            new Quote { Text = "Our job is to give people not what they want, but what we decide they ought to have." , Author = "Richard Salent, Former President CBS News" },
            new Quote { Text = "You can pretend to be serious; you can't pretend to be witty." , Author = "Sacha Guitry" },
            new Quote { Text = "Two attitudes are all that is needed; do not harm anything, say and do things that make others happy." , Author = "dreamslaughter" },
            new Quote { Text = "In spite of everything I still believe that people are really good at heart." , Author = "Anne Frank, holocaust victim" },
            new Quote { Text = "Why is propaganda so much more successful when it stirs up hatred than when it tries to stir up friendly feeling?" , Author = "Bertrand Russell" },
            new Quote { Text = "Nature does not hurry, yet everything is accomplished." , Author = "Lao tzu" },
            new Quote { Text = "The illegal we do immediately. The unconstitutional takes a bit longer." , Author = "Henry Kissinger" },
            // 780

            new Quote { Text = "The victor will never be asked if he told the truth." , Author = "Adolf Hitler" },
            new Quote { Text = "What sane person could live in this world and not be crazy?" , Author = "Ursula K. LeGuin" },
            new Quote { Text = "Never express yourself more clearly than you think." , Author = "Neils Bohr" },
            new Quote { Text = "Modern morality and manners suppress all natural instincts, keep people ignorant of the facts of nature and make them fighting drunk on bogey tales." , Author = "Aleister Crowley" },
            new Quote { Text = "The right things to do are those that keep our violence in abeyance; the wrong things are those that bring it to the fore." , Author = "Robert J. Sawyer" },
            new Quote { Text = "When you are content to be simply yourself and don't compare or compete, everybody will respect you." , Author = "Lao tzu" },
            new Quote { Text = "What is the use of a house if you haven't got a tolerable planet to put it on?" , Author = "Henry David Thoreau" },
            new Quote { Text = "I consider Christian theology to be one of the greatest disasters of the human race." , Author = "Alfred North Whitehead" },
            new Quote { Text = "Most people drive thru life with the parking brake on." , Author = "Lance Bradley" },
            new Quote { Text = "Truth is living, it is not static, and the mind that would discover truth must also be living, not burdened with knowledge or experience." , Author = "J. Krishnamurthi" },
            // 790

            new Quote { Text = "If everyone demanded peace instead of another television set, then there'd be peace." , Author = "John Lennon" },
            new Quote { Text = "The biggest conspiracy of all is the claim that there are no conspiracies!" , Author = "Michael Rivero" },
            new Quote { Text = "The death of dogma is the birth of morality." , Author = "Immanuel Kant" },
            new Quote { Text = "Can you sympathize with an exploding star?" , Author = "Shawn Mikula" },
            new Quote { Text = "The revolution is a dictatorship of the exploited against the exploiters." , Author = "Fidel Castro" },
            new Quote { Text = "Whoever imagines himself a favorite with God holds others in contempt." , Author = "Robert G. Ingersoll" },
            new Quote { Text = "Simplicity is the ultimate sophistication." , Author = "Leonardo da Vinci" },
            new Quote { Text = "All religions are founded on the fear of the many and the cleverness of the few." , Author = "Stendhal" },
            new Quote { Text = "Today it is fashionable to talk about the poor. Unfortunately, it is not fashionable to talk with them." , Author = "Mother Teresa" },
            new Quote { Text = "No man's knowledge here can go beyond his experience." , Author = "John A. Locke" },
            // 800

            #endregion

            #region 801 - 900

            new Quote { Text = "Life's under no obligation to give us what we expect." , Author = "Margaret Mitchell" },
            new Quote { Text = "The history of war is the history of powerful individuals willing to sacrifice thousands upon thousands of other people's lives for personal gains." , Author = "Michael Rivero" },
            new Quote { Text = "Being with a woman all night never hurt no professional baseball player. It's staying up all night looking for a woman that does him in." , Author = "Casey Stengel" },
            new Quote { Text = "The religion of the future will be a cosmic religion, the religion which based on experience, which refuses dogma." , Author = "Albert Einstein" },
            new Quote { Text = "It is curious that physical courage should be so common in the world and moral courage so rare." , Author = "Mark Twain" },
            new Quote { Text = "Do not mind anything that anyone tells you about anyone else. Judge everyone and everything for yourself." , Author = "Henry James" },
            new Quote { Text = "When a thing has been said and said well, have no scruple. Take it and copy it." , Author = "Anatole France" },
            new Quote { Text = "The secret of happiness is to admire without desiring." , Author = "F. H. Bradley" },
            new Quote { Text = "To travel is to discover that everyone is wrong about other countries." , Author = "Aldous Huxley" },
            new Quote { Text = "Pray: To ask the laws of the universe to be annulled on behalf of a single petitioner confessedly unworthy." , Author = "Ambrose Bierce" },
            // 810
            
            new Quote { Text = "The greatest deception men suffer is from their own opinions." , Author = "Leonardo da Vinci" },
            new Quote { Text = "Even if truth destroys the whole universe, still it is truth; stand by it." , Author = "Swami Vivekananda" },
            new Quote { Text = "The actions of men are the best interpreters of their thoughts." , Author = "John Locke" },
            new Quote { Text = "Christians are supposed not merely to endure change, nor even to profit by it, but to cause it." , Author = "Harry Emerson Fosdick" },
            new Quote { Text = "Every man is guilty of all the good he didn't do." , Author = "Voltaire" },
            new Quote { Text = "Put your hand on a hot stove for a minute, and it seems like an hour. Sit with a pretty girl for an hour, and it seems like a minute. That's relativity." , Author = "Albert Einstein" },
            new Quote { Text = "If you would be a real seeker after truth, it is necessary that at least once in your life you doubt, as far as possible, all things." , Author = "Rene Descartes" },
            new Quote { Text = "Time wounds all heels." , Author = "Jane Ace" },
            new Quote { Text = "Beware of all enterprises that require new clothes." , Author = "Henry David Thoreau" },
            new Quote { Text = "Manifest plainness, embrace simplicity, reduce selfishness, have few desires." , Author = "Lao tzu" },
            // 820

            new Quote { Text = "When a man says he approves of something in principle, it means he hasn't the slightest intention of carrying it out in practice." , Author = "Otto von Bismarck" },
            new Quote { Text = "A man's character is his fate." , Author = "Heraclitus" },
            new Quote { Text = "Quarrels would not last long if only one side was wrong." , Author = "Francois Duc de la Rochefoucauld" },
            new Quote { Text = "Philosophers have merely interpreted the world. The point is to change it." , Author = "Karl Marx" },
            new Quote { Text = "I am not a communist and neither is the revolutionary movement." , Author = "Fidel Castro" },
            new Quote { Text = "When a nation's young men are conservative, its funeral bell is already rung." , Author = "Henry Ward Beecher" },
            new Quote { Text = "Science is the great antidote to the poison of enthusiasm and superstition." , Author = "Adam Smith" },
            new Quote { Text = "The Brush Dance is a Yurok healing ritual where being true to yourself means give your best to a person in need. Being true to yourself is the one and only Yurok Indian Law." , Author = "Brush Dance Journal" },
            new Quote { Text = "Happiness is an imaginary condition, formerly attributed by the living to the dead, now usually attributed by adults to children, and by children to adults." , Author = "Thomas Szasz" },
            new Quote { Text = "Never explain, your friends do not need it and your enemies will not believe you anyway." , Author = "Elbert Hubbard" },
            // 830

            new Quote { Text = "The pious pretense that evil does not exist only makes it vague, enormous and menacing." , Author = "Aleister Crowley" },
            new Quote { Text = "Once all struggle is grasped, miracles are possible." , Author = "Mao Tse Tung" },
            new Quote { Text = "Everybody sooner or later, sits down to a banquet of consequences." , Author = "Robert Louis Stevenson" },
            new Quote { Text = "We will be known by the tracks we leave behind." , Author = "Dakota proverb" },
            new Quote { Text = "If a scholar aspires to the Way but is ashamed of bad clothes and bad food, he isn't ready to join the discussion yet." , Author = "Confucius" },
            new Quote { Text = "Earth provides enough to satisfy every man's need, but not every man's greed." , Author = "Mohandas Gandhi" },
            new Quote { Text = "So long as the media are in corporate hands, the task of social change will be vastly more difficult, if not impossible." , Author = "Robert McChesney" },
            new Quote { Text = "It is wrong always, everywhere, and for anyone, to believe anything upon insufficient evidence." , Author = "William Kingdon Clifford" },
            new Quote { Text = "I do not believe that any type of religion should ever be introduced into the public schools of the United States." , Author = "Thomas Edison" },
            new Quote { Text = "The radical invents the views. When he has worn them out, the conservative adopts them." , Author = "Mark Twain" },
            // 840

            new Quote { Text = "Monarchy degenerates into tyranny, aristocracy into oligarchy, and democracy into savage violence and chaos." , Author = "Polybius" },
            new Quote { Text = "Never interrupt your enemy when he is making a mistake." , Author = "Napoleon" },
            new Quote { Text = "When the water starts boiling it is foolish to turn off the heat." , Author = "Nelson Mandela" },
            new Quote { Text = "The spirit of resistance to government is so valuable on certain occasions that I wish it to be always kept alive." , Author = "Thomas Jefferson" },
            new Quote { Text = "If we continue to develop our technology without wisdom or prudence, our servant may prove to be our executioner." , Author = "General Omar N. Bradley" },
            new Quote { Text = "The rights of women are sacred. See that women are maintained in the rights attributed to them." , Author = "Prophet Muhammed" },
            new Quote { Text = "Try not to become a man of success but rather to become a man of value." , Author = "Albert Einstein" },
            new Quote { Text = "When you meet a worthy person, focus on reaching his level. When you meet an unworthy person, take a good look inside yourself." , Author = "Confucius" },
            new Quote { Text = "If one were to take the bible seriously one would go mad. But to take the bible seriously, one must be already mad." , Author = "Aleister Crowley" },
            new Quote { Text = "All my humor is based upon destruction and despair. If the whole world were tranquil, without disease and violence, I'd be standing on the breadline right in back of J. Edgar Hoover." , Author = "Lenny Bruce" },
            // 850

            new Quote { Text = "If I can't dance, I don't want to be part of your revolution." , Author = "Emma Goldman" },
            new Quote { Text = "It is not what we do, but also what we do not do, for which we are accountable." , Author = "Moliere" },
            new Quote { Text = "Religion is excellent stuff for keeping common people quiet." , Author = "Napoleon" },
            new Quote { Text = "Living is change; Growth is optional." , Author = "Juan Wa Chang" },
            new Quote { Text = "Religion is an insult to human dignity. With or without it, you'd have good people doing good things and evil people doing bad things, but for good people to do bad things, it takes religion." , Author = "Steven Weinberg" },
            new Quote { Text = "It is difficult to produce a television documentary that is both incisive and probing when every twelve minutes one is interrupted by twelve dancing rabbits singing about toilet paper." , Author = "Rod Serling" },
            new Quote { Text = "You have not converted a man because you have silenced him." , Author = "John Morley" },
            new Quote { Text = "We have a political system that awards office to the most ruthless, cunning, and selfish of mortals, then act surprised when those willing to do anything to win power are equally willing to do anything with it." , Author = "Michael Rivero" },
            new Quote { Text = "Use what talent you possess: the woods would be very silent if no birds sang except those that sang best." , Author = "Henry Van Dyke" },
            new Quote { Text = "The hardest years in life are those between ten and seventy." , Author = "Helen Hayes, age 83" },
            // 860

            new Quote { Text = "Everything has been figured out, except how to live." , Author = "Jean Paul Sartre" },
            new Quote { Text = "The vast majority of mankind is trapped within perceptual prisons." , Author = "Shawn Mikula" },
            new Quote { Text = "What difference does it make how much you have? What you do not have amounts to much more." , Author = "Seneca" },
            new Quote { Text = "America ... just a nation of two hundred million used car salesmen with all the money we need to buy guns and no qualms about killing anybody else in the world who tries to make us uncomfortable." , Author = "Hunter S. Thompson" },
            new Quote { Text = "The government of the United States does not, in its policies, express the decency of its people." , Author = "Jerry Fresia" },
            new Quote { Text = "Grasshopper, look beyond the game, as you look beneath the surface of the pool to see its depths." , Author = "Master Po" },
            new Quote { Text = "Write injuries in sand, kindnesses in marble." , Author = "French proverb" },
            new Quote { Text = "Kindness is a mark of faith, and whoever has not kindness has not faith." , Author = "Prophet Muhammad" },
            new Quote { Text = "It is not impossible to govern Italians. It is merely useless." , Author = "Benito Mussolini" },
            new Quote { Text = "Only two things are infinite, the universe and human stupidity, and I'm not sure about the former." , Author = "Albert Einstein" },
            // 870

            new Quote { Text = "Every revolution evaporates and leaves behind it only the slime of bureaucracy." , Author = "Franz Kafka" },
            new Quote { Text = "Always remember you are a totally unique individual; just like everyone else." , Author = "Unknown" },
            new Quote { Text = "Mythology is what we call someone else's religion." , Author = "Joseph Campbell" },
            new Quote { Text = "Christian is a verb not a noun." , Author = "Meria Heller" },
            new Quote { Text = "Someday man will imprison the power of the sun, release atomic power, and harness the rise and fall of the tides. I am proud of the fact that I never invented weapons to kill." , Author = "Thomas Edison" },
            new Quote { Text = "Beware the man of one book." , Author = "Saint Thomas Aquinas" },
            new Quote { Text = "If we don't believe in freedom of expression for people we despise, we don't believe in it at all." , Author = "Noam Chomsky" },
            new Quote { Text = "The only thing we never get enough of is love; and the only thing we never give enough of is love." , Author = "Henry Miller" },
            new Quote { Text = "The United States is not nearly so concerned that its acts be kept secret from its intended victims as it is that the American people not know of them." , Author = "Ramsey Clark" },
            new Quote { Text = "Nothing exists except atoms and empty space; everything else is opinion." , Author = "Democritus" },
            // 880

            new Quote { Text = "Cancel the kitchen scraps for lepers and orphans! No more merciful beheadings! And call off Christmas!" , Author = "The Sheriff of Nottingham" },
            new Quote { Text = "The god of the cannibals will be a cannibal, of the crusaders, a crusader, and of the merchants a merchant." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "The degree of one's emotion varies inversely with one's knowledge of the facts. The less you know, the hotter you get." , Author = "Bertrand Russel" },
            new Quote { Text = "Knowing others is intelligence; knowing yourself is true wisdom. Mastering others is strength; mastering yourself is true power." , Author = "Lao Tzu" },
            new Quote { Text = "The believer is happy; the doubter is wise." , Author = "Hungarian Proverb" },
            new Quote { Text = "I complained that I had no shoes until I met a man who had no feet." , Author = "Persian proverb" },
            new Quote { Text = "Rules of Optimization: Rule 1: Don't do it. Rule 2 (for experts only): Don't do it yet." , Author = "M.A. Jackson" },
            new Quote { Text = "More computing sins are committed in the name of efficiency (without necessarily achieving it) than for any other single reason - including blind stupidity." , Author = "W.A. Wulf" },
            new Quote { Text = "We should forget about small efficiencies, say about 97% of the time: premature optimization is the root of all evil." , Author = "Donald Knuth" },
            new Quote { Text = "Mother-in-law = A woman who destroys her son-in-law's peace of mind by giving him a piece of hers." , Author = "Anonymous" },
            // 890

            new Quote { Text = "May God grant me the grace to one day know the truth. Until then, may he spare me the company of those who've already found it." , Author = "unknown" },
            new Quote { Text = "If you try and take a cat apart to see how it works, the first thing you have in your hands is a non-working cat." , Author = "Douglas Adams" },
            new Quote { Text = "Finagle's Law of Dynamic Negatives: Anything that can go wrong, will, at the worst possible moment." },
            new Quote { Text = "Many journalists have fallen for the conspiracy theory of government. I do assure you that they would produce more accurate work if they adhered to the cock-up theory." , Author = "Sir Bernard Ingham" },
            new Quote { Text = "Genius may have its limitations, but stupidity is not thus handicapped." , Author = "Elbert Hubbard" },
            new Quote { Text = "Asswhole = a complete ass" , Author = "John McTaggart in bpot" },
            new Quote { Text = "Don't drive me crazy, it's within walking distance." },
            new Quote { Text = "I have seen the future and it is just like the present, only longer." , Author = "Albran" },
            new Quote { Text = "Smoking is one of the leading causes of statistics." , Author = "Fletcher Knebel" },
            new Quote { Text = "Machine. Unexpectedly, I'd invented a time." , Author = "Alan Moore" },
            // 900

            #endregion

            #region 901 - 1000

            new Quote { Text = "If Tyranny and Oppression come to this land, it will be in the guise of fighting a foreign enemy." , Author = "James Madison" },
            new Quote { Text = "The problem with people who have no vices is that generally you can be pretty sure they're going to have some pretty annoying virtues." , Author = "Elizabeth Taylor" },
            new Quote { Text = "Talk sense to a fool and he calls you foolish." , Author = "Euripides" },
            new Quote { Text = "Invading Iraq after 9/11 was like invading Mexico after Pearl Harbor." , Author = "Richard Clarke" },
            new Quote { Text = "I've never seen anyone change his mind because of the power of a superior argument or the acquisition of new facts. But I've seen plenty of people change behavior to avoid being mocked." , Author = "Scott Adams" },
            new Quote { Text = "The years of peak mental activity are undoubtedly between the ages of four and eighteen.  At four we know all the questions, at eighteen all the answers." , Author = "unknown" },
            new Quote { Text = "I'm fed up to the ears with old men dreaming up wars for young men to die in." , Author = "George McGovern" },
            new Quote { Text = "The music business is a cruel and shallow money trench, a long plastic hallway where thieves and pimps run free, and good men die like dogs. There's also a negative side", Author = "Hunter S. Thompson" },
            new Quote { Text = "Pardon him, Theodotus; he is a barbarian, and thinks that the customs of his tribe and island are the laws of nature." , Author = "George Bernard Shaw" },
            new Quote { Text = "The competent programmer is fully aware of the limited size of his own skull. He therefore approaches his task with full humility, and avoids clever tricks like the plague." , Author = "Edsger W. Dijkstra, EWD340" },
            // 910

            new Quote { Text = "Ignorance simplifies any problem." , Author = "R. Lucke" },
            new Quote { Text = "Before the war is ended, the war party assumes the divine right to denounce and silence all opposition to war as unpatriotic and cowardly." , Author = "Senator Robert M. La Follette" },
            new Quote { Text = "After every 'victory' you have more enemies." , Author = "Jeanette Winterson" },
            new Quote { Text = "Our children are not born to hate, they are raised to hate." , Author = "Thomas della Peruta" },
            new Quote { Text = "The shepherd always tries to persuade the sheep that their interests and his own are the same." , Author = "Marie Beyle" },
            new Quote { Text = "I hate those men who would send into war youth to fight and die for them; the pride and cowardice of those old men, making their wars that boys must die." , Author = "Mary Roberts Rinehart" },
            new Quote { Text = "Guard against the impostures of pretended patriotism." , Author = "George Washington" },
            new Quote { Text = "The de facto role of the US armed forces will be to keep the world safe for our economy and open to our cultural assault." , Author = "Major Ralph Peters, US Military" },
            new Quote { Text = "Patriotism means to stand by the country. It does not mean to stand by the president or any other public official..." , Author = "Theodore Roosevelt" },
            new Quote { Text = "The worst crimes were dared by a few, willed by more and tolerated by all." , Author = "Tacitus" },
            // 920

            new Quote { Text = "Only a free and unrestrained press can effectively expose deception in government." , Author = "Hugo Black, Supreme Court Justice" },
            new Quote { Text = "War is fear cloaked in courage." , Author = "General William Westmoreland" },
            new Quote { Text = "What is morally wrong can never be advantageous, even when it enables you to make some gain that you believe to be to your advantage." , Author = "Marcus Tullius Cicero" },
            new Quote { Text = "Everybody's worried about stopping terrorism. Well, there's a really easy way: stop participating in it." , Author = "Noam Chomsky" },
            new Quote { Text = "It is far easier to make war than peace." , Author = "Georges Clemenceau" },
            new Quote { Text = "The belief in the possibility of a short decisive war appears to be one of the most ancient and dangerous of human illusions." , Author = "Robert Lynd" },
            new Quote { Text = "Of all the enemies to public liberty, war is perhaps the most to be dreaded because it comprises and develops the germ of every other." , Author = "James Madison" },
            new Quote { Text = "War doesn't make boys men, it makes men dead." , Author = "Ken Gillespie" },
            new Quote { Text = "Every nation has its war party. It is not the party of democracy. It is the party of autocracy. It seeks to dominate absolutely." , Author = "Senator Robert M. La Follette" },
            new Quote { Text = "It is the job of thinking people not to be on the side of the executioners." , Author = "Albert Camus" },
            // 930

            new Quote { Text = "Paramount among the responsibilities of a free press is the duty to prevent any part of the government from deceiving the people." , Author = "Hugo Black, Supreme Court Justice" },
            new Quote { Text = "Liberty and democracy become unholy when their hands are dyed red with innocent blood." , Author = "Mahatma Gandhi" },
            new Quote { Text = "Peace is constructed, not fought for." , Author = "Brent Davis" },
            new Quote { Text = "In this war - as in others - I am less interested in honoring the dead than in preventing the dead." , Author = "Butler Shaffer" },
            new Quote { Text = "It is only those who have neither fired a shot nor heard the shrieks and groans of the wounded who cry aloud for blood... War is hell." , Author = "General William Tecumseh Sherman" },
            new Quote { Text = "It is dangerous to be right when the government is wrong." , Author = "Voltaire" },
            new Quote { Text = "The worst barbarity of war is that it forces men collectively to commit acts against which individually they would revolt with their whole being." , Author = "Ellen Key" },
            new Quote { Text = "Some men, in order to prevent the supposed intentions of their adversaries, have committed the most enormous cruelties." , Author = "Clearchus, in Xenophon" },
            new Quote { Text = "War might be avoidable were more emphasis placed on the training to social interest, less on the attainment of egotistical grandeur." , Author = "Lydia Sicher" },
            new Quote { Text = "Look at you in war. There has never been a just one, never an honorable one, on the part of the instigator of the war." , Author = "Mark Twain" },
            // 940

            new Quote { Text = "Everything secret degenerates, even the administration of justice." , Author = "Lord Acton" },
            new Quote { Text = "Military justice is to justice what military music is to music." , Author = "Groucho Marx" },
            new Quote { Text = "Violence is the last refuge of the incompetent." , Author = "Issac Asimov" },
            new Quote { Text = "A state of war only serves as an excuse for domestic tyranny." , Author = "Aleksandr Solzhenitsyn" },
            new Quote { Text = "War is not the continuation of politics with different means, it is the greatest mass-crime perpetrated on the community of man." , Author = "Alfred Adler" },
            new Quote { Text = "We will not learn how to live together in peace by killing each other's children." , Author = "Jimmy Carter" },
            new Quote { Text = "The dangerous patriot ... is a defender of militarism and its ideals of war and glory." , Author = "Colonel James A. Donovan, Marine Corps" },
            new Quote { Text = "To jaw-jaw is always better than to war-war." , Author = "Winston Churchill" },
            new Quote { Text = "Man has no right to kill his brother. It is no excuse that he does so in uniform: he only adds the infamy of servitude to the crime of murder." , Author = "Percy Bysshe Shelley" },
            new Quote { Text = "Is it not a strange blindness on our part to teach publicly the techniques of warfare and to reward with medals those who prove to be the most adroit killers?" , Author = "Marquis de Sade" },
            // 950

            new Quote { Text = "The cry has been that when war is declared, all opposition should be hushed. A sentiment more unworthy of a free country could hardly be propagated." , Author = "William Ellery Channing" },
            new Quote { Text = "Our government has kept us in a perpetual state of fear - kept us in a continuous stampede of patriotic fervor - with the cry of grave national emergency." , Author = "General Douglas MacArthur" },
            new Quote { Text = "The internet is not something you just dump something on. It's not a truck. It's a series of tubes!" , Author = "Senator Ted Stevens" },
            new Quote { Text = "Elegance is not a dispensable luxury but a factor that decides between success and failure." , Author = "Edsger Dijkstra" },
            new Quote { Text = "It's wonderful to be here in the great state of Chicago." , Author = "Dan Quayle" },
            new Quote { Text = "If Al Gore invented the Internet, I invented spell check." , Author = "Dan Quayle" },
            new Quote { Text = "My current job sucks so hard, black holes are going green with envy." , Author = "Liz Kimber" },
            new Quote { Text = "I was playing poker the other night... with Tarot cards. I got a full house and 4 people died." , Author = "Steven Wright" },
            new Quote { Text = "'Everything you say is boring and incomprehensible', she said, 'but that alone doesn't make it true.'" , Author = "Franz Kafka" },
            new Quote { Text = "Should array indices start at 0 or 1? My compromise of 0.5 was rejected without, I thought, proper consideration." , Author = "Stan Kelly-Bootle" },
            // 960

            new Quote { Text = "If electricity comes from electrons, does that mean that morality comes from morons?" , Author = "Unknown" },
            new Quote { Text = "The company doesn't tell me what to say, and I don't tell them where to stick it." , Author = "Unknown" },
            new Quote { Text = "The only way to combat criminals is by not voting for them." , Author = "Dayton Allen" },
            new Quote { Text = "A camel is a horse designed by a committee" , Author = "Unknown" },
            new Quote { Text = "I'm not under the alkafluence of inkahol that some thinkle peep I am. It's just the drunker I sit here the longer I get." , Author = "Unknown" },
            new Quote { Text = "A great many people think they are thinking when they are merely rearranging their prejudices." , Author = "William James" },
            new Quote { Text = "The whole problem with the world is that fools and fanatics are always so certain of themselves, but wiser people so full of doubts." , Author = "Bertrand Russell" },
            new Quote { Text = "The bureaucracy is expanding to meet the needs of an expanding bureaucracy." , Author = "Unknown" },
            new Quote { Text = "I took a course in speed reading and was able to read War and Peace in twenty minutes.  It's about Russia." , Author = "Woody Allen" },
            new Quote { Text = "There are only two ways to live your life. One is as though nothing is a miracle. The other is as though everything is a miracle." , Author = "Albert Einstein" },
            // 970

            new Quote { Text = "Jesus may love you, but I think you're garbage wrapped in skin." , Author = "Michael O'Donohugh" },
            new Quote { Text = "Subtlety is the art of saying what you think and getting out of the way before it is understood." , Author = "Unknown" },
            new Quote { Text = "Tact is the ability to tell a man he has an open mind when he has a hole in his head." , Author = "Unknown" },
            new Quote { Text = "The study of non-linear physics is like the study of non-elephant biology." , Author = "Unknown" },
            new Quote { Text = "I do not have a body, I am a body." , Author = "Unknown" },
            new Quote { Text = "If people are good only because they fear punishment, and hope for reward, then we are a sorry lot indeed." , Author = "Albert Einstein" },
            new Quote { Text = "A radioactive cat has eighteen half-lives." , Author = "Unknown" },
            new Quote { Text = "Clothes make the man.  Naked people have little or no influence on society." , Author = "Mark Twain" },
            new Quote { Text = "I doubt, therefore I might be." , Author = "Unknown" },
            new Quote { Text = "If you believe in telekinesis, raise my hand." , Author = "Unknown" },
            // 980

            new Quote { Text = "Light thinks it travels faster than anything but it is wrong. No matter how fast light travels, it finds the darkness has always got there first, and is waiting for it." , Author = "Terry Pratchett (Reaper Man)" },
            new Quote { Text = "If you take something apart and put it back together again enough times, you will eventually have enough parts left over to build a second one." , Author = "The law of inanimate reproduction" },
            new Quote { Text = "I have spoken many a word, therefore, it is fact." , Author = "Eric the Verbose" },
            new Quote { Text = "Puritanism: The haunting fear that someone, somewhere, may be happy." , Author = "H. L. Mencken" },
            new Quote { Text = "Roses are #FF0000 Violets are #0000FF All my base are belong to you!" , Author = "Geek Valentine T-shirt" },
            new Quote { Text = "The surest way to corrupt a youth is to instruct him to hold in higher esteem those who think alike than those who think differently" , Author = "Friedrich Nietzsche" },
            new Quote { Text = "Conservatives are not necessarily stupid, but most stupid people are conservatives" , Author = "John Stuart Mill" },
            new Quote { Text = "Throughout American history, the government has said we're in an unprecedented crisis and that we must live without civil liberties until the crisis is over. It's a hoax." , Author = "Yale Kamisar" },
            new Quote { Text = "Under conditions of competition, standards are set by the morally least reputable agent." , Author = "John Stuart Mill" },
            new Quote { Text = "A terrorist is someone who has a bomb, but doesn't have an air force." , Author = "William Blum" },
            // 990

            new Quote { Text = "You cannot depend on your eyes when your imagination is out of focus." , Author = "Mark Twain" },
            new Quote { Text = "There are only two tragedies in life: one is not getting what one wants, and the other is getting it." , Author = "Oscar Wilde" },
            new Quote { Text = "When the rich think about the poor, they have poor ideas." , Author = "Evita Peron" },
            new Quote { Text = "Any fool can criticize, condemn, and complain - and most fools do." , Author = "Dale Carnegie" },
            new Quote { Text = "Real punks help little old ladies across the street because it shocks more people than if they spit on the sidewalk." , Author = "Unknown" },
            new Quote { Text = "If you can read this you're not aiming in the right direction." , Author = "Toilet-ceiling graffiti" },
            new Quote { Text = "Getting an education was a bit like a communicable sexual disease. It made you unsuitable for a lot of jobs and then you had the urge to pass it on." , Author = "Terry Pratchett, Hogfather" },
            new Quote { Text = "To understand a man you should walk a mile in his shoes. If what he says still bothers you that's ok because you'll be a mile away from him and you'll have his shoes." , Author = "Unknown" },
            new Quote { Text = "I'm trying to see things from your point of view but I can't get my head that far up my ass." , Author = "- Unknown" },
            new Quote { Text = "Early to rise, early to bed, makes a man healthy but socially dead." , Author = "The Warner Brothers (Animaniacs)" },
            // 1000

            #endregion

            #region 1001 - 1100

            new Quote { Text = "I hope life isn't a big joke ... because I don't get it." , Author = "Unknown" },
            new Quote { Text = "I'd stop eating chocolate, but I'm no quitter." , Author = "Unknown" },
            new Quote { Text = "I'm so poor I can't even pay attention." , Author = "Unknown" },
            new Quote { Text = "It's dangerous to underestimate the intelligence of a customer who grew a business that's successful enough to require a large and complex set of software" , Author = "Grady Booch" },
            new Quote { Text = "A physicist is an atom's way of knowing about atoms." , Author = "George Wald" },
            new Quote { Text = "It's the liberal bias. The press is liberally biased to the right." , Author = "Ken de Camargo" },
            new Quote { Text = "That is the saving grace of humor, if you fail no one is laughing at you." , Author = "A. Whitney Brown" },
            new Quote { Text = "Humor is the only test of gravity, and gravity of humor; for a subject which will not bear raillery is suspicious, and a jest which will not bear serious examination is false wit." , Author = "Aristotle" },
            new Quote { Text = "All I need to make a comedy is a park, a policeman and a pretty girl." , Author = "Charlie Chaplin" },
            new Quote { Text = "Total absence of humor renders life impossible." , Author = "Colette" },
            // 1010

            new Quote { Text = "Humor is always based on a modicum of truth. Have you ever heard a joke about a father-in-law?" , Author = "Dick Clark" },
            new Quote { Text = "A sense of humor is part of the art of leadership, of getting along with people, of getting things done." , Author = "Dwight D. Eisenhower" },
            new Quote { Text = "Analyzing humor is like dissecting a frog. Few people are interested and the frog dies of it." , Author = "E. B. White" },
            new Quote { Text = "Humor is by far the most significant activity of the human brain." , Author = "Edward De Bono" },
            new Quote { Text = "The world is a tragedy to those who feel, but a comedy to those who think." , Author = "Horace Walpole" },
            new Quote { Text = "If there's one thing I know it's god does love a good joke." , Author = "Hugh Elliott" },
            new Quote { Text = "The only rules comedy can tolerate are those of taste, and the only limitations those of libel." , Author = "James Thurber" },
            new Quote { Text = "The wit makes fun of other persons; the satirist makes fun of the world; the humorist makes fun of himself." , Author = "James Thurber" },
            new Quote { Text = "Where humor is concerned there are no standards - no one can say what is good or bad, although you can be sure that everyone will." , Author = "John Kenneth Galbraith" },
            new Quote { Text = "One doesn't have a sense of humor. It has you." , Author = "Larry Gelbart" },
            // 1020

            new Quote { Text = "Humor is the great thing, the saving thing. The minute it crops up, all our irritations and resentments slip away and a sunny spirit takes their place." , Author = "Mark Twain" },
            new Quote { Text = "Humor is a rubber sword - it allows you to make a point without drawing blood." , Author = "Mary Hirsch" },
            new Quote { Text = "Humor is just another defense against the universe." , Author = "Mel Brooks" },
            new Quote { Text = "Comedy is simply a funny way of being serious." , Author = " Peter Ustinov" },
            new Quote { Text = "Comedy is nothing more than tragedy deferred." , Author = "Pico Iyer, Time" },
            new Quote { Text = "Wit makes its own welcome and levels all distinctions." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "Defining and analyzing humor is a pastime of humorless people." , Author = "Robert Benchley" },
            new Quote { Text = "Humor is also a way of saying something serious." , Author = "T. S. Eliot" },
            new Quote { Text = "There's no trick to being a humorist when you have the whole government working for you." , Author = "Will Rogers" },
            new Quote { Text = "Politicians are like diapers. They should be changed often, and for the same reason." , Author = "Anonymous" },
            // 1030

            new Quote { Text = "Small minds run in the same gutter." , Author = "Alfred E. Neuman" },
            new Quote { Text = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the Universe trying to produce bigger and better idiots. So far, the Universe is winning." , Author = "Rich Cook" },
            new Quote { Text = "Computer dating is fine, if you're a computer." , Author = "Rita May Brown" },
            new Quote { Text = "All sorts of computer errors are now turning up. You'd be surprised to know the number of doctors who claim they are treating pregnant men." , Author = "Isaac Asimov" },
            new Quote { Text = "To err is human, but to really foul things up you need a computer." , Author = "Paul Ehrlich" },
            new Quote { Text = "The trouble with the Internet is that it's replacing masturbation as a leisure activity." , Author = "Patrick Murray" },
            new Quote { Text = "Beware of computer programmers that carry screwdrivers." , Author = "Leonard Brandwein" },
            new Quote { Text = "UNIX is basically a simple operating system, but you have to be a genius to understand the simplicity." , Author = "Dennis Ritchie" },
            new Quote { Text = "The perfect computer has been developed. You just feed in your problems and they never come out again." , Author = "Al Goodman" },
            new Quote { Text = "The most overlooked advantage of owning a computer is that if they foul up there's no law against whacking them around a bit." , Author = "Eric Porterfield" },
            // 1040

            new Quote { Text = "Computers make it easier to do a lot of things, but most of the things they make it easier to do don't need to be done." , Author = "Andy Rooney" },
            new Quote { Text = "Computer Science is no more about computers than astronomy is about telescopes" , Author = "Edsger W. Dijkstra" },
            new Quote { Text = "The great thing about a computer notebook is that no matter how much you stuff into it, it doesn't get bigger or heavier." , Author = "Bill Gates" },
            new Quote { Text = "Not even computers will replace committees, because committees buy computers." , Author = "Unknown" },
            new Quote { Text = "I do not fear computers. I fear the lack of them." , Author = "Isaac Asimov" },
            new Quote { Text = "Computers can figure out all kinds of problems, except the things in the world that just don't add up." , Author = "James Magary" },
            new Quote { Text = "In all large corporations, there is a pervasive fear that someone, somewhere is having fun with a computer on company time. Networks help alleviate that fear." , Author = "John C. Dvorak" },
            new Quote { Text = "Imagine if every Thursday your shoes exploded if you tied them the usual way. This happens to us all the time with computers, and nobody thinks of complaining." , Author = "Jeff Raskin" },
            new Quote { Text = "The most likely way for the world to be destroyed, most experts agree, is by accident. That's where we come in; we're computer professionals. We cause accidents." , Author = "Nathaniel Borenstein" },
            new Quote { Text = "If the automobile had followed the same development cycle as the computer, a Rolls-Royce would today cost $100, get a million miles per gallon, and explode once a year, killing everyone inside." , Author = "Robert X. Cringely" },
            // 1050

            new Quote { Text = "If you put tomfoolery into a computer, nothing comes out of it but tomfoolery. But this tomfoolery, having passed through a very expensive machine, is somehow enobled and no-one dares criticize it." , Author = "Pierre Gallois" },
            new Quote { Text = "Descended from the apes? Let us hope that it is not true. But if it is, let us pray that it may not become generally known." , Author = "FA Montagu" },
            new Quote { Text = "I am an expert of electricity. My father occupied the chair of applied electricity at the state prison." , Author = "WC Fields" },
            new Quote { Text = "My advice to you is get married: if you find a good wife you'll be happy; if not, you'll become a philosopher." , Author = "Socrates" },
            new Quote { Text = "Research is what I'm doing when I don't know what I'm doing." , Author = "Wernher Von Braun" },
            new Quote { Text = "You ask me if I keep a notebook to record my great ideas. I've only ever had one." , Author = "Albert Einstein" },
            new Quote { Text = "Only one man ever understood me, and he didn't understand me." , Author = "GW Hegel" },
            new Quote { Text = "Chaos Theory is a new theory invented by scientists panicked by the thought that the public were beginning to understand the old ones." , Author = "Mike Barfield" },
            new Quote { Text = "The secret of creativity is knowing how to hide your sources." , Author = "Albert Einstein" },
            new Quote { Text = "Louis Pasteur's theory of germs is ridiculous fiction." , Author = "Pierre Pachet, Professor of Physiology at Toulouse, 1872" },
            // 1060

            new Quote { Text = "The wireless music box has no imaginable commercial value. Who would pay for a message sent to nobody in particular?" , Author = "David Sarnoff's associates on radio" },
            new Quote { Text = "If it weren't for electricity we'd all be watching television by candlelight." , Author = "George Gobel" },
            new Quote { Text = "USA Today has come out with a new survey: Apparently three out of four people make up 75 percent of the population." , Author = "David Letterman" },
            new Quote { Text = "In ancient times they had no statistics so they had to fall back on lies." , Author = "Stephen Leacock" },
            new Quote { Text = "Ketchup left overnight on dinner plates has a longer half-life than radioactive waste." , Author = "Wes Smith" },
            new Quote { Text = "Biologically speaking, if something bites you it's more likely to be female." , Author = "Desmond Morris" },
            new Quote { Text = "When I die I'm going to leave my body to science fiction." , Author = "Steven Wright" },
            new Quote { Text = "Inanimate objects can be classified scientifically into three major categories; those that don't work, those that break down and those that get lost." , Author = "Russell Baker" },
            new Quote { Text = "Heaven is an American salary, a Chinese cook, an English house, and a Japanese wife. Hell is defined as having a Chinese salary, an English cook, a Japanese house, and an American wife." , Author = "James H. Kabbler III" },
            new Quote { Text = "How can I believe in God when just last week I got my tongue caught in the roller of an electric typewriter?" , Author = "Woody Allen" },
            // 1070

            new Quote { Text = "If there is no god, who pops up the next Kleenex?" , Author = "Art Hoppe" },
            new Quote { Text = "I was thrown out of college for cheating on the metaphysics exam; I looked into the soul of the boy next to me." , Author = "Woody Allen" },
            new Quote { Text = "A good sermon should be like a woman's skirt: short enough to arouse interest but long enough to cover the essentials." , Author = "Ronald Knox" },
            new Quote { Text = "Not only is there no god, but you try getting a plumber at weekends." , Author = "Woody Allen" },
            new Quote { Text = "As god once said, and I think rightly..." , Author = "Margaret Thatcher" },
            new Quote { Text = "Hearing nuns' confessions is like being stoned to death with popcorn." , Author = "Fulton Sheen" },
            new Quote { Text = "If there is no Hell, a good many preachers are obtaining money under false pretences." , Author = "William Sunday" },
            new Quote { Text = "I admire the Pope. I have a lot of respect for anyone who can tour without an album." , Author = "Rita Rudner" },
            new Quote { Text = "Thank god I'm an atheist." , Author = "Luis Bunuel" },
            new Quote { Text = "The Bible was a consolation to a fellow alone in the old cell. The lovely thin paper with a bit of matress stuffing in it, if you could get a match, was as good a smoke as I ever tasted." , Author = "Brendan Behan" },
            // 1080

            new Quote { Text = "In the begining there was nothing and god said 'Let there be light', and there was still nothing but everybody could see it." , Author = "Dave Thomas" },
            new Quote { Text = "Sailors ought never to go to church. They ought to go to hell, where it is much more comfortable." , Author = "HG Wells" },
            new Quote { Text = "If absolute power corrupts absolutely, where does that leave god?" , Author = "George Deacon" },
            new Quote { Text = "I don't believe in the after life, although I am bringing a change of underwear." , Author = "Woody Allen" },
            new Quote { Text = "When I was a kid I used to pray every night for a new bicycle. Then I realised that the Lord doesn't work that way so I stole one and asked Him to forgive me." , Author = "Emo Philips" },
            new Quote { Text = "When I told the people of Northern Ireland that I was an atheist, a woman in the audience stood up and said, 'Yes, but is it the God of the Catholics or the God of the Protestants in whom you don't believe?" , Author = "Quentin Crisp" },
            new Quote { Text = "When I am dead, I hope it may be said: 'His sins were scarlet but his books were read." , Author = "Hillaire Belloc" },
            new Quote { Text = "Sometimes I lie awake at night, and I ask, 'Where have I gone wrong?' Then a voice says to me, 'This is going to take more than one night.'" , Author = "Charlie Brown" },
            new Quote { Text = "Maybe there is no actual place called hell. Maybe hell is just having to listen to our grandparents breathe through their noses when they're eating sandwiches." , Author = "Jim Carrey" },
            new Quote { Text = "When did I realize I was God? Well, I was praying and I suddenly realized I was talking to myself." , Author = "Peter O'Toole" },
            // 1090

            new Quote { Text = "They say such nice things about people at their funerals that it makes me sad that I'm going to miss mine by just a few days." , Author = "Garrison Kielor" },
            new Quote { Text = "It was god who made me so beautiful. If I weren't, then I'd be a teacher." , Author = "Linda Evangelista" },
            new Quote { Text = "The secret of a good sermon is to have a good beginning and a good ending, then having the two as close together as possible." , Author = "George Burns" },
            new Quote { Text = "The truth is more important than the facts." , Author = "Frank Lloyd Wright" },
            new Quote { Text = "I was raised in the Jewish tradition, taught never to marry a Gentile woman, shave on a Saturday night and, most especially, never to shave a Gentile woman on a Saturday night." , Author = "Woody Allen" },
            new Quote { Text = "God is love, but get it in writing." , Author = "Gypsy Rose Lee" },
            new Quote { Text = "I don't pray because I don't want to bore God." , Author = "Orson Welles" },
            new Quote { Text = "As the poet said, 'Only God can make a tree,' probably because it's so hard to figure out how to get the bark on." , Author = "Woody Allen" },
            new Quote { Text = "I have four children which is not bad considering I'm not a Catholic." , Author = "Peter Ustinov" },
            new Quote { Text = "I hear Glenn Hoddle has found God. That must have been one hell of a pass." , Author = "Bob Davies" },
            // 1100

            #endregion

            #region 1101 - 1200

            new Quote { Text = "And God said, 'Let there be light' and there was light, but the Electricity Board said He would have to wait until Thursday to be connected." , Author = "Spike Milligan" },
            new Quote { Text = "No mention of god. They keep him up their sleeves for as long as they can, vicars do. They know it puts people off." , Author = "Alan Bennett" },
            new Quote { Text = "I'm Jewish. I don't work out. If God had wanted us to bend over, He would have put diamonds on the floor." , Author = "Joan Rivers" },
            new Quote { Text = "There is a charm about the forbidden that makes it unspeakably diserable." , Author = "Mark Twain" },
            new Quote { Text = "Always go to other people's funerals, otherwise they won't come to yours." , Author = "Yogi Berra" },
            new Quote { Text = "Death is a low chemical trick played on everybody except sequoia trees." , Author = "JJ Furnas" },
            new Quote { Text = "Dying is a very dull, dreary affair. And my advice to you is to have nothing whatever to do with it." , Author = "W. Somerset Maugham" },
            new Quote { Text = "The man who does not read good books has no advantage over the man who cannot read them." , Author = "Mark Twain" },
            new Quote { Text = "Everybody wants to go to heaven, but nobody wants to die." , Author = "Joe Louis" },
            new Quote { Text = "He had decided to live forever or die in the attempt." , Author = "Joseph Heller" },
            // 1110

            new Quote { Text = "I am ready to meet my Maker. Whether my Maker is prepared for the great ordeal of meeting me is another matter." , Author = "Winston Churchill" },
            new Quote { Text = "Death is one of the few things that can be done as easily lying down. The difference between sex and death is that with death you can do it alone and no one is going to make fun of you." , Author = "Woody Allen" },
            new Quote { Text = "All our knowledge merely helps us to die a more painful death than animals that know nothing." , Author = "Maurice Maeterlinck" },
            new Quote { Text = "Eternal nothingness is fine if you happen to be dressed for it." , Author = "Woody Allen" },
            new Quote { Text = "I just bought a Mac to help me design the next Cray." , Author = "Seymoure Cray" },
            new Quote { Text = "Everything is drive-through. In California, they even have a burial service called Jump-In-The-Box." , Author = "Wil Shriner" },
            new Quote { Text = "In this world, nothing is certain but death and taxes." , Author = "Benjamin Franklin" },
            new Quote { Text = "The fear of death is the most unjustified of all fears, for there's no risk of accident for someone who's dead." , Author = "Albert Einstein" },
            new Quote { Text = "I wouldn't mind dying - it's the business of having to stay dead that scares the shit out of me." , Author = "R. Geis" },
            new Quote { Text = "It's impossible to experience one's death objectively and still carry a tune." , Author = "Woody Allen" },
            // 1120

            new Quote { Text = "For if he like a madman lived, At least he like a wise one died." , Author = "Cervantes" },
            new Quote { Text = "Death does not concern us, because as long as we exist, death is not here. And when it does come, we no longer exist." , Author = "Epicurus" },
            new Quote { Text = "Am I lightheaded because I'm not dead or because I'm still alive?" , Author = "Heidi Sandige" },
            new Quote { Text = "A low voter turnout is an indication of fewer people going to the polls." , Author = "George W. Bush" },
            new Quote { Text = "I was raised in the West. The west of Texas. It's pretty close to California. In more ways than Washington, D.C., is close to California." , Author = "George W. Bush" },
            new Quote { Text = "Rarely is the question asked: Is our children learning?" , Author = "George W. Bush" },
            new Quote { Text = "It's clearly a budget. It's got a lot of numbers in it." , Author = "George W. Bush" },
            new Quote { Text = "One word sums up probably the responsibility of any Governor, and that one word is 'to be prepared'." , Author = "George W. Bush" },
            new Quote { Text = "If you're sick and tired of the politics of cynicism and polls and principles, come and join this campaign." , Author = "George W. Bush" },
            new Quote { Text = "We must all hear the universal call to like your neighbor like you like to be liked yourself." , Author = "George W. Bush" },
            // 1130

            new Quote { Text = "The most important job is not to be Governor, or First Lady in my case." , Author = "George W. Bush" },
            new Quote { Text = "If people can judge me on the company I keep, they would judge me with keeping really good company with Laura." , Author = "George W. Bush" },
            new Quote { Text = "You'll notice that Nancy Reagan never drinks water when Ronnie speaks." , Author = "Robin Williams" },
            new Quote { Text = "I'm not going to have some reporters pawing through our papers. We are the president." , Author = "Hillary Clinton" },
            new Quote { Text = "A committee is a group of people who individually can do nothing but together can decide that nothing can be done." , Author = "Fred Allen" },
            new Quote { Text = "Richard Nixon is a no good, lying bastard. He can lie out of both sides of his mouth at the same time, and if he ever caught himself telling the truth, he'd lie just to keep his hand in." , Author = "Harry S. Truman" },
            new Quote { Text = "Behind every successful man is a woman, behind her is his wife." , Author = "Groucho Marx" },
            new Quote { Text = "Marry me and I'll never look at another horse!" , Author = "Groucho Marx" },
            new Quote { Text = "A woman is an occasional pleasure but a cigar is always a smoke." , Author = "Groucho Marx" },
            new Quote { Text = "Outside of a dog, a book is man's best friend. Inside of a dog, it's too dark to read." , Author = "Groucho Marx" },
            // 1140

            new Quote { Text = "Why was I with her? She reminds me of you. In fact, she reminds me more of you than you do!" , Author = "Groucho Marx" },
            new Quote { Text = "Women should be obscene and not heard." , Author = "Groucho Marx" },
            new Quote { Text = "Either he's dead or my watch has stopped." , Author = "Groucho Marx" },
            new Quote { Text = "I don't care to belong to a club that accepts people like me as members." , Author = "Groucho Marx" },
            new Quote { Text = "I must confess, I was born at a very early age." , Author = "Groucho Marx" },
            new Quote { Text = "I have had a perfectly wonderful evening, but this wasn't it." , Author = "Groucho Marx" },
            new Quote { Text = "Room service? Send up a larger room." , Author = "Groucho Marx" },
            new Quote { Text = "I never forget a face, but in your case I'll be glad to make an exception." , Author = "Groucho Marx" },
            new Quote { Text = "A man's only as old as the woman he feels." , Author = "Groucho Marx" },
            new Quote { Text = "One morning I shot a bear in my pajamas. How it got into my pajamas I'll never know." , Author = "Groucho Marx" },
            // 1150

            new Quote { Text = "If I held you any closer I would be on the other side of you." , Author = "Groucho Marx" },
            new Quote { Text = "I was married by a judge. I should have asked for a jury." , Author = "Groucho Marx" },
            new Quote { Text = "Who are you going to believe, me or your own eyes?" , Author = "Groucho Marx" },
            new Quote { Text = "Quote me as saying I was mis-quoted." , Author = "Groucho Marx" },
            new Quote { Text = "A child of five could understand this. Fetch me a child of five." , Author = "Groucho Marx" },
            new Quote { Text = "Those are my principles. If you don't like them I have others." , Author = "Groucho Marx" },
            new Quote { Text = "Police arrested two kids yesterday, one was drinking battery acid, the other was eating fireworks. They charged one and let the other one off." , Author = "Tommy Cooper" },
            new Quote { Text = "It's strange, isn't it. You stand in the middle of a library and go 'aaaaagghhhh' and everyone just stares at you. But you do the same thing on an aeroplane, and everyone joins in." , Author = "Tommy Cooper" },
            new Quote { Text = "You know, somebody actually complimented me on my driving today. They left a little note on the windscreen, it said 'Parking Fine.'" , Author = "Tommy Cooper" },
            new Quote { Text = "So I rang up a local building firm, I said 'I want a skip outside my house.' He said 'I'm not stopping you.'" , Author = "Tommy Cooper" },
            // 1160

            new Quote { Text = "It's not that I'm afraid to die, I just don't want to be there when it happens." , Author = "Woody Allen" },
            new Quote { Text = "There are worse things in life than death. Have you ever spent an evening with an insurance salesman?" , Author = "Woody Allen" },
            new Quote { Text = "Money is better than poverty, if only for financial reasons." , Author = "Woody Allen" },
            new Quote { Text = "I failed to make the chess team because of my height." , Author = "Woody Allen" },
            new Quote { Text = "I'm very proud of my gold pocket watch. My grandfather, on his deathbed, sold me this watch." , Author = "Woody Allen" },
            new Quote { Text = "The Stones, I love the Stones. I watch them whenever I can. Fred, Barney..." , Author = "Steven Wright" },
            new Quote { Text = "He would make a lovely corpse." , Author = "Charles Dickens" },
            new Quote { Text = "I've just learned about his illness. Let's hope it's nothing trivial." , Author = "Irvin S. Cobb" },
            new Quote { Text = "I worship the quicksand he walks in." , Author = "Art Buchwald" },
            new Quote { Text = "Wagner's music is better than it sounds." , Author = "Mark Twain" },
            // 1170

            new Quote { Text = "First you forget names, then you forget faces. Next you forget to pull your zipper up and finally, you forget to pull it down." , Author = "George Burns" },
            new Quote { Text = "The pen is mightier than the sword, and considerably easier to write with." , Author = "Marty Feldman" },
            new Quote { Text = "We had gay burglars the other night. They broke in and rearranged the furniture." , Author = "Robin Williams" },
            new Quote { Text = "If toast always lands butter-side down, and cats always land on their feet, what happens if you strap toast on the back of a cat and drop it?" , Author = "Steven Wright" },
            new Quote { Text = "I'm desperately trying to figure out why kamikaze pilots wore helmets." , Author = "Dave Edison" },
            new Quote { Text = "Did you ever walk in a room and forget why you walked in? I think that's how dogs spend their lives." , Author = "Sue Murphy" },
            new Quote { Text = "A sure cure for seasickness is to sit under a tree." , Author = "Spike Milligan" },
            new Quote { Text = "Why don't they make the whole plane out of that black box stuff." , Author = "Steven Wright" },
            new Quote { Text = "I once heard two ladies going on and on about the pains of childbirth and how men don't seem to know what real pain is. I asked if either of them ever got themselves caught in a zipper.", Author = "Emo Philips" },
            new Quote { Text = "My neighbour asked if he could use my lawnmower and I told him of course he could, so long as he didn't take it out of my garden." , Author = "Eric Morecambe" },
            // 1180

            new Quote { Text = "You're about as useful as a one-legged man at an arse kicking contest." , Author = "Rowan Atkinson" },
            new Quote { Text = "He managed to stupid himself right into the White House." , Author = "Charles Appel about George W. Bush" },
            new Quote { Text = "Reality is that which, when you stop believing in it, doesn't go away." , Author = "Philip K. Dick" },
            new Quote { Text = "Believe those who are seeking the truth. Doubt those who find it." , Author = "André Gide" },
            new Quote { Text = "Just because bulldozers are used to build highways doesn't mean bulldozers are the best way to travel on a highway." , Author = "Danny Thorpe" },
            new Quote { Text = "Write a wise word and your name will live forever." , Author = "Anonymous" },
            new Quote { Text = "To the Honourable Member opposite I say, when he goes home tonight, may his mother run out from under the porch and bark at him" , Author = "John G. Diefenbaker" },
            new Quote { Text = "Minsky's Second Law: Don't just do something. Stand there." , Author = "Marvin Minsky" },
            new Quote { Text = "Devlin's First Law - Buyer beware: in the hands of a charlatan, mathematics can be used to make a vacuous argument look impressive. Devlin's Second Law - So can PowerPoint." , Author = "Keith Devlin" },
            new Quote { Text = "Gigerenzer's Law of Indispensable Ignorance: The world cannot function without partially ignorant people." , Author = "Gerd Gigerenzer" },
            // 1190

            new Quote { Text = "Lohr's Law: The future is merely the past with a twist - and better tools." , Author = "Steve Lohr" },
            new Quote { Text = "Raymond's Law of Software: Given a sufficiently large number of eyeballs, all bugs are shallow." , Author = "Eric S. Raymond" },
            new Quote { Text = "Barabási's Law of Programming: Program development ends when the program does what you expect it to do - whether it is correct or not." , Author = "Albert-László Barabási" },
            new Quote { Text = "Anyone who starts a sentence, 'With all due respect ...' is about to insult you." , Author = "unknown" },
            new Quote { Text = "The only one listening to both sides of an argument is the neighbor in the next apartment" , Author = "unknown" },
            new Quote { Text = "Cholesterol is your natural defence against excessive circulation of blood, which can carry venoms, poisons and other toxins around your body." , Author = "Michael Warner" },
            new Quote { Text = "There Ought to be Limits to Freedom!" , Author = "George W. Bush" },
            new Quote { Text = "We are Dyslexia of Borg. Fusistance is retile. Your ass will be laminated." , Author = "unknown" },
            new Quote { Text = "I don't approve of political jokes... I've seen too many of them get elected." , Author = "unknown" },
            new Quote { Text = "I plan to live forever. So far so good." , Author = "Rob C. Claffie" },
            // 1200

            #endregion

            #region 1201 - 1300

            new Quote { Text = "Millions long for immortality who do not know what to do with themselves on a rainy Sunday afternoon." , Author = "Susan Ertz" },
            new Quote { Text = "If the United Nations once admits that international disputes can be settled by using force, then we will have destroyed the foundation of the organization and our best hope of establishing a world order." , Author = "Dwight D. Eisenhower" },
            new Quote { Text = "When you hear hoofbeats, think of horses, not zebras." , Author = "Old saying" },
            new Quote { Text = "A picture is worth a thousand words (which is why it takes a thousand times longer to load...)" , Author = "Eric Tilton, Composing Good HTML" },
            new Quote { Text = "1001 words say more than one picture" , Author = "Chinese proverb" },
            new Quote { Text = "There is no idea so simple and powerful that you can't get zillions of people to misunderstand it." , Author = "Alan Kay" },
            new Quote { Text = "The purpose of computing is not numbers but insight." , Author = "Richard Hamming" },
            new Quote { Text = "They have computers, and they may have other weapons of mass destruction." , Author = "Janet Reno, Us Attorney General" },
            new Quote { Text = "Absence of evidence is not evidence of absence." , Author = "Source Unknown" },
            new Quote { Text = "Imagine if every Thursday your shoes exploded if you tied them the usual way. This happens to us all the time with computers, and nobody thinks of complaining." , Author = "Jeff Raskin" },
            // 1210

            new Quote { Text = "#3 pencils and quadrille pads." , Author = "Seymoure Cray when asked what CAD tools he used to design the Cray I supercomputer" },
            new Quote { Text = "Linux is like living in a teepee. No Windows, no Gates, Apache in house." , Author = "Usenet signature" },
            new Quote { Text = "Politics is the art of looking for trouble, finding it everywhere, diagnosing it incorrectly, and applying the wrong remedies." , Author = "Groucho Marx" },
            new Quote { Text = "Momma always said life was like a box of chocolates. You never know what you're gonna get." , Author = "Forest Gump" },
            new Quote { Text = "I invented the term Object-Oriented, and I can tell you I did not have C++ in mind." , Author = "Alan Kay" },
            new Quote { Text = "Reality is merely an illusion, albeit a very persistent one." , Author = "Albert Einstein" },
            new Quote { Text = "Never test for an error condition you don't know how to handle." , Author = "Steinbach's Guideline for Systems Programmers" },
            new Quote { Text = "Science is what people understand well enough to explain to a computer. All else is art." , Author = "Donald Knuth" },
            new Quote { Text = "Beware of bugs in the above code; I have only proven it correct, not tried it." , Author = "Donald Knuth" },
            new Quote { Text = "Object-oriented programming is an exceptionally bad idea which could only have originated in California." , Author = "Edsger Dijkstra" },
            // 1220

            new Quote { Text = "Object-oriented programming is a style of programming designed to teach students about stacks." , Author = "Edsger Dijkstra" },
            new Quote { Text = "Programming is one of the most difficult branches of applied mathematics; the poorer mathematicians had better remain pure mathematicians." , Author = "Edsger Dijkstra" },
            new Quote { Text = "The use of anthropomorphic terminology when dealing with computing systems is a symptom of professional immaturity." , Author = "Edsger Dijkstra" },
            new Quote { Text = "About the use of language: it is impossible to sharpen a pencil with a blunt axe. It is equally vain to try to do it with ten blunt axes instead." , Author = "Edsger W. Dijkstra" },
            new Quote { Text = "If FORTRAN has been called an infantile disorder, then PL/I must be classified as a fatal disease." , Author = "Edsger Dijkstra" },
            new Quote { Text = "Testing proves the presence, not the absence, of bugs." , Author = "Edsger Dijkstra" },
            new Quote { Text = "The question of whether a computer can think is no more interesting than the question of whether a submarine can swim." , Author = "Edsger Dijkstra" },
            new Quote { Text = "The use of COBOL cripples the mind; its teaching should, therefore, be regarded as a criminal offense." , Author = "Edsger Dijkstra" },
            new Quote { Text = "If we knew what it was we were doing, it would not be called research, would it?" , Author = "Albert Einstein" },
            new Quote { Text = "If you were plowing a field, which would you rather use? Two strong oxen or 1024 chickens?" , Author = "Seymour Cray, father of supercomputing" },
            // 1230

            new Quote { Text = "We are not retreating - we are advancing in another Direction." , Author = "General Douglas MacArthur" },
            new Quote { Text = "A model is done when nothing else can be taken out." , Author = "Dyson" },
            new Quote { Text = "Real life is that big, high-res, high-color screen saver behind all the windows." , Author = "Unknown" },
            new Quote { Text = "We've all heard that a million monkeys banging on a million typewriters will eventually reproduce the entire works of Shakespeare. Now, thanks to the Internet, we know this is not true." , Author = "Robert Wilensky" },
            new Quote { Text = "Not everything that can be counted counts, and not everything that counts can be counted." , Author = "Albert Einstein" },
            new Quote { Text = "Physics is not a religion. If it were, we'd have a much easier time raising money." , Author = "Leon Lenderman" },
            new Quote { Text = "Java, the best argument for Smalltalk since C++." , Author = "Unknown" },
            new Quote { Text = "Life would be so much easier if we could just see the source code." , Author = "Unknown" },
            new Quote { Text = "Deliver yesterday, code today, think tomorrow." , Author = "Unknown" },
            new Quote { Text = "A poem is never finished, only abandoned." , Author = "Paul Valery" },
            // 1240

            new Quote { Text = "Having the source code is the difference between buying a house and renting an apartment." , Author = "Behlendorf" },
            new Quote { Text = "C++: an octopus made by nailing extra legs onto a dog" , Author = "Unknown" },
            new Quote { Text = "C combines all the power of assembly language with the ease of use of assembly language" , Author = "Unknown" },
            new Quote { Text = "God is real unless declared integer" , Author = "David" },
            new Quote { Text = "Java: the elegant simplicity of C++ and the blazing speed of Smalltalk." , Author = "Roland Turner" },
            new Quote { Text = "Quotation confesses inferiority." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "A mind all logic is like a knife all blade. It makes the hand bleed that uses it." , Author = "Rabindranath Tagore" },
            new Quote { Text = "Sometimes, the best answer is a more interesting question" , Author = "Terry Pratchett" },
            new Quote { Text = "Before C++ we had to code all of our bugs by hand; now we inherit them." , Author = "Unknown" },
            new Quote { Text = "Incrementing C by 1 is not enough to make a good object-oriented language."  , Author = "M. Sakkinen" },
            // 1250

            new Quote { Text = "Fill the unforgiving minute with sixty seconds worth of distance run." , Author = "Rudyard Kipling" },
            new Quote { Text = "Man is the best computer we can put aboard a spacecraft... and the only one that can be mass produced with unskilled labor." , Author = "Wernher von Braun" },
            new Quote { Text = "Computer /nm./: a device designed to speed and automate errors." , Author = "From the Jargon File" },
            new Quote { Text = "RAM /abr./: Rarely Adequate Memory." , Author = "From the Jargon File" },
            new Quote { Text = "A printer consists of three main parts: the case, the jammed paper tray and the blinking red light" , Author = "Unknown" },
            new Quote { Text = "Real Programmers always confuse Christmas and Halloween because Oct31 == Dec25 !" , Author = "Andrew Rutherford" },
            new Quote { Text = "2 + 2 = 5, for extremely large values of 2." , Author = "Unknown" },
            new Quote { Text = "ASCII stupid question, get a stupid ANSI !" , Author = "Unknown" },
            new Quote { Text = "Multitasking /adj./ 3 PCs and a chair with wheels !" , Author = "Unknown" },
            new Quote { Text = "Pascal /n./ A programming language named after a man who would turn over in his grave if he knew about it." , Author = "From the Jargon File" },
            // 1260

            new Quote { Text = "If it wasn't for C, we'd be writing programs in BASI, PASAL, and OBOL." , Author = "Unknown" },
            new Quote { Text = "I have yet to meet a C compiler that is more friendly and easier to use than eating soup with a knife." , Author = "Unknown" },
            new Quote { Text = "One of the main causes of the fall of the Roman Empire was that, lacking zero, they had no way to indicate successful termination of their C programs." , Author = "Robert Firth" },
            new Quote { Text = "We should leave our minds open, but not so open that our brains fall out." , Author = "Alan Ross Anderson" },
            new Quote { Text = "The difference between what the most and the least learned people know is inexpressibly trivial in relation to that which is unknown."  , Author = "Albert Einstein" },
            new Quote { Text = "Statistics is like a bikini. What they reveal is suggestive. What they conceal is vital." , Author = "Arthur Koestler" },
            new Quote { Text = "A hen is only an egg's way of making another egg." , Author = "Samuel Butler" },
            new Quote { Text = "It is a miracle that curiosity survives formal education." , Author = "Albert Einstein" },
            new Quote { Text = "Gravity cannot be held responsible for people falling in love." , Author = "Albert Einstein" },
            new Quote { Text = "Common sense is the collection of prejudices acquired by age eighteen." , Author = "Albert Einstein" },
            // 1270

            new Quote { Text = "The secret to creativity is knowing how to hide your sources." , Author = "Albert Einstein" },
            new Quote { Text = "Intellectuals solve problems; geniuses prevent them." , Author = "Albert Einstein" },
            new Quote { Text = "If you give a man a fish, he will eat for today. If you teach him to fish, he'll understand why some people think golf is exciting." , Author = "P.G. Wodehouse" },
            new Quote { Text = "I'd give my right arm to be ambidextrous." , Author = "Brian Kernighan" },
            new Quote { Text = "I know that there are people in this world who do not love their fellow human beings, and I hate people like that." , Author = "Tom Lehrer" },
            new Quote { Text = "Yes, I'm fat, but you're ugly and I can go on a diet." , Author = "Bumper sticker" },
            new Quote { Text = "For centuries, theologians have been explaining the unknowable in terms of the-not-worth-knowing." , Author = "Henry Louis Mencken" },
            new Quote { Text = "Every normal man must be tempted at times to spit upon his hands, hoist the black flag, and begin slitting throats." , Author = "Henry Louis Mencken" },
            new Quote { Text = "Now, now my good man, this is no time for making enemies." , Author = "Voltaire on his deathbed in response to a priest asking that he renounce Satan" },
            new Quote { Text = "This isn't right, this isn't even wrong." , Author = "Wolfgang Pauli, upon reading a young physicist's paper" },
            // 1280

            new Quote { Text = "I want to die in my sleep like my grandfather... not screaming and yelling like the passengers in his car..." , Author = "Bumper sticker" },
            new Quote { Text = "Woman was God's second mistake." , Author = "Friedrich Nietzsche" },
            new Quote { Text = "Diplomacy is the art of saying 'Nice doggie!'... 'til you can find a rock." , Author = "Bumper sticker" },
            new Quote { Text = "Ever stop to think, and forget to start again?" , Author = "Bumper sticker" },
            new Quote { Text = "If you need more than five lines to prove something, then you are on the wrong track" , Author = "Edgser W. Dijkstra's mother" },
            new Quote { Text = "If you think it's simple, then you have misunderstood the problem." , Author = "Bjarne Stroustrup" },
            new Quote { Text = "True. When your hammer is C++, everything begins to look like a thumb." , Author = "Steve Haflich" },
            new Quote { Text = "I have made this letter longer than usual because I lack the time to make it shorter." , Author = "Blaise Pascal" },
            new Quote { Text = "Modern capitalism is not about free markets, it is about building sufficient mass that the market gravitationally collapses around you.", Author = "Alisdair Meredith" },
            new Quote { Text = "If quantum physics doesn't confuse you then you don't understand it." , Author = "Niels Bohr" },
            // 1290

            new Quote { Text = "If the brain were so simple we could understand it, we would be so simple we couldn't." , Author = "Lyall Watson" },
            new Quote { Text = "Moral indignation is jealousy with a halo." , Author = "H. G. Wells" },
            new Quote { Text = "Glory is fleeting, but obscurity is forever." , Author = "Napoleon Bonaparte" },
            new Quote { Text = "Victory goes to the player who makes the next-to-last mistake." , Author = "Chessmaster Savielly Grigorievitch Tartakower" },
            new Quote { Text = "Don't be so humble - you are not that great." , Author = "Golda Meir to a visiting diplomat" },
            new Quote { Text = "His ignorance is encyclopedic" , Author = "Abba Eban" },
            new Quote { Text = "If a man does his best, what else is there?" , Author = "General George S. Patton" },
            new Quote { Text = "I can write better than anybody who can write faster, and I can write faster than anybody who can write better." , Author = "A. J. Liebling" },
            new Quote { Text = "People demand freedom of speech to make up for the freedom of thought which they avoid." , Author = "Soren Aabye Kierkegaard" },
            new Quote { Text = "Give me chastity and continence, but not yet." , Author = "Saint Augustine" },
            // 1300

            #endregion

            #region 1301 - 1400

            new Quote { Text = "Love is friendship set on fire." , Author = "Jeremy Taylor" },
            new Quote { Text = "God gave men both a penis and a brain, but unfortunately not enough blood supply to run both at the same time." , Author = "Robin Williams" },
            new Quote { Text = "I criticize by creation - not by finding fault." , Author = "Cicero" },
            new Quote { Text = "A lie gets halfway around the world before the truth has a chance to get its pants on." , Author = "Sir Winston Churchill" },
            new Quote { Text = "The artist is nothing without the gift, but the gift is nothing without work." , Author = "Emile Zola" },
            new Quote { Text = "This book fills a much-needed gap." , Author = "Moses Hadas in a review" },
            new Quote { Text = "I'm living so far beyond my income that we may almost be said to be living apart." , Author = "E. E. Cummings" },
            new Quote { Text = "Give me a museum and I'll fill it." , Author = "Pablo Picasso" },
            new Quote { Text = "Assassins!" , Author = "Arturo Toscanini to his orchestra" },
            new Quote { Text = "I'll moider da bum." , Author = "Boxer Tony Galento about William Shakespeare" },
            // 1310

            new Quote { Text = "In theory, there is no difference between theory and practice. But, in practice, there is." , Author = "Jan L.A. van de Snepscheut" },
            new Quote { Text = "I find that the harder I work, the more luck I seem to have." , Author = "Thomas Jefferson" },
            new Quote { Text = "Whether you think that you can, or that you can't, you are usually right." , Author = "Henry Ford" },
            new Quote { Text = "Do, or do not. There is no 'try'." , Author = "Yoda" },
            new Quote { Text = "The only way to get rid of a temptation is to yield to it." , Author = "Oscar Wilde" },
            new Quote { Text = "Don't stay in bed, unless you can make money in bed." , Author = "George Burns" },
            new Quote { Text = "I don't know why we are here, but I'm pretty sure that it is not in order to enjoy ourselves." , Author = "Ludwig Wittgenstein" },
            new Quote { Text = "The use of COBOL cripples the mind; its teaching should, therefore, be regarded as a criminal offense." , Author = "Edsger Dijkstra" },
            new Quote { Text = "There is only one nature - the division into science and engineering is a human imposition, not a natural one. Indeed, the division is a human failure; it reflects our limited capacity to comprehend the whole." , Author = "Bill Wulf" },
            new Quote { Text = "There's many a bestseller that could have been prevented by a good teacher." , Author = "Flannery O'Connor" },
            // 1320

            new Quote { Text = "Half this game is ninety percent mental." , Author = "Yogi Berra" },
            new Quote { Text = "The only difference between me and a madman is that I'm not mad." , Author = "Salvador Dali" },
            new Quote { Text = "If you can't get rid of the skeleton in your closet, you'd best teach it to dance." , Author = "George Bernard Shaw" },
            new Quote { Text = "But at my back I always hear Time's winged chariot hurrying near." , Author = "Andrew Marvell" },
            new Quote { Text = "Good people do not need laws to tell them to act responsibly, while bad people will find a way around the laws." , Author = "Plato" },
            new Quote { Text = "The power of accurate observation is frequently called cynicism by those who don't have it." , Author = "George Bernard Shaw" },
            new Quote { Text = "I think 'Hail to the Chief' has a nice ring to it." , Author = "John F. Kennedy when asked what is his favorite song" },
            new Quote { Text = "Human history becomes more and more a race between education and catastrophe." , Author = "H. G. Wells" },
            new Quote { Text = "The difference between 'involvement' and 'commitment' is like an eggs-and-ham breakfast: the chicken was 'involved' - the pig was 'committed'." , Author = "Unknown" },
            new Quote { Text = "I'm all in favor of keeping dangerous weapons out of the hands of fools. Let's start with typewriters." , Author = "Frank Lloyd Wright" },
            // 1330

            new Quote { Text = "We're going to turn this team around 360 degrees." , Author = "Jason Kidd, upon his drafting to the Dallas Mavericks" },
            new Quote { Text = "God is a comedian playing to an audience too afraid to laugh." , Author = "Voltaire" },
            new Quote { Text = "He is one of those people who would be enormously improved by death." , Author = "H. H. Munro" },
            new Quote { Text = "I shall not waste my days in trying to prolong them." , Author = "Ian L. Fleming" },
            new Quote { Text = "If you can count your money, you don't have a billion dollars." , Author = "J. Paul Getty" },
            new Quote { Text = "When you do the common things in life in an uncommon way, you will command the attention of the world." , Author = "George Washington Carver" },
            new Quote { Text = "How wrong it is for a woman to expect the man to build the world she wants, rather than to create it herself." , Author = "Anais Nin" },
            new Quote { Text = "I have not failed. I've just found 10,000 ways that won't work." , Author = "Thomas Alva Edison" },
            new Quote { Text = "I begin by taking. I shall find scholars later to demonstrate my perfect right." , Author = "Frederick (II) the Great" },
            new Quote { Text = "The President has kept all of the promises he intended to keep." , Author = "Clinton aide George Stephanopolous speaking on Larry King Live" },
            // 1340

            new Quote { Text = "Blessed is the man, who having nothing to say, abstains from giving wordy evidence of the fact." , Author = "George Eliot" },
            new Quote { Text = "Once you eliminate the impossible, whatever remains, no matter how improbable, must be the truth." , Author = "Sherlock Holmes" },
            new Quote { Text = "A friendship founded on business is better than a business founded on friendship." , Author = "John D. Rockefeller" },
            new Quote { Text = "All are lunatics, but he who can analyze his delusion is called a philosopher." , Author = "Ambrose Bierce" },
            new Quote { Text = "You can only find truth with logic if you have already found truth without it." , Author = "Gilbert Keith Chesterton" },
            new Quote { Text = "An inconvenience is only an adventure wrongly considered; an adventure is an inconvenience rightly considered." , Author = "Gilbert Keith Chesterton" },
            new Quote { Text = "I have come to believe that the whole world is an enigma, a harmless enigma that is made terrible by our own mad attempt to interpret it as though it had an underlying truth." , Author = "Umberto Eco" },
            new Quote { Text = "The difference between fiction and reality? Fiction has to make sense." , Author = "Tom Clancy" },
            new Quote { Text = "It's not the size of the dog in the fight, it's the size of the fight in the dog." , Author = "Mark Twain" },
            new Quote { Text = "Whatever is begun in anger ends in shame." , Author = "Benjamin Franklin" },
            // 1350

            new Quote { Text = "Be nice to people on your way up because you meet them on your way down." , Author = "Jimmy Durante" },
            new Quote { Text = "The true measure of a man is how he treats someone who can do him absolutely no good." , Author = "Samuel Johnson" },
            new Quote { Text = "A people that values its privileges above its principles soon loses both." , Author = "Dwight D. Eisenhower" },
            new Quote { Text = "The significant problems we face cannot be solved at the same level of thinking we were at when we created them." , Author = "Albert Einstein" },
            new Quote { Text = "Basically, I no longer work for anything but the sensation I have while working." , Author = "Albert Giacometti" },
            new Quote { Text = "All truth passes through three stages. First, it is ridiculed. Second, it is violently opposed. Third, it is accepted as being self-evident." , Author = "Arthur Schopenhauer" },
            new Quote { Text = "Many a man's reputation would not know his character if they met on the street." , Author = "Elbert Hubbard" },
            new Quote { Text = "There is more stupidity than hydrogen in the universe, and it has a longer shelf life." , Author = "Frank Zappa" },
            new Quote { Text = "Life is pleasant. Death is peaceful. It's the transition that's troublesome." , Author = "Isaac Asimov" },
            new Quote { Text = "The right to swing my fist ends where the other man's nose begins." , Author = "Oliver Wendell Holmes" },
            // 1360

            new Quote { Text = "If you want to make an apple pie from scratch, you must first create the universe." , Author = "Carl Sagan" },
            new Quote { Text = "It is much more comfortable to be mad and know it, than to be sane and have one's doubts." , Author = "G. B. Burgin" },
            new Quote { Text = "To love oneself is the beginning of a lifelong romance" , Author = "Oscar Wilde " },
            new Quote { Text = "Knowledge speaks, but wisdom listens." , Author = "Jimi Hendrix" },
            new Quote { Text = "A clever man commits no minor blunders." , Author = "Goethe" },
            new Quote { Text = "Argue for your limitations, and sure enough they're yours." , Author = "Richard Bach" },
            new Quote { Text = "A witty saying proves nothing." , Author = "Voltaire" },
            new Quote { Text = "Education is a progressive discovery of our own ignorance." , Author = "Will Durant" },
            new Quote { Text = "If everything seems under control, you're just not going fast enough." , Author = "Mario Andretti" },
            new Quote { Text = "Don't let it end like this. Tell them I said something." , Author = "Dying words of Pancho Villa" },
            // 1370

            new Quote { Text = "Obstacles are those frightful things you see when you take your eyes off your goal." , Author = "Henry Ford" },
            new Quote { Text = "I'll sleep when I'm dead." , Author = "Warren Zevon" },
            new Quote { Text = "There are people in the world so hungry, that god cannot appear to them except in the form of bread." , Author = "Mahatma Gandhi" },
            new Quote { Text = "If you gaze long into an abyss, the abyss will gaze back into you." , Author = "Friedrich Nietzsche" },
            new Quote { Text = "Everyone is a genius at least once a year; a real genius has his original ideas closer together." , Author = "Georg Lichtenberg" },
            new Quote { Text = "Success usually comes to those who are too busy to be looking for it" , Author = "Henry David Thoreau" },
            new Quote { Text = "While we are postponing, life speeds by." , Author = "Seneca" },
            new Quote { Text = "Where are we going, and why am I in this handbasket?" , Author = "Bumper Sticker" },
            new Quote { Text = "God, please save me from your followers!" , Author = "Bumper Sticker" },
            new Quote { Text = "Fill what's empty, empty what's full, and scratch where it itches." , Author = "the Duchess of Windsor, when asked what is the secret of a long and happy life" },
            // 1380

            new Quote { Text = "First they ignore you, then they laugh at you, then they fight you, then you win." , Author = "Mahatma Gandhi" },
            new Quote { Text = "Luck is the residue of design." , Author = "Branch Rickey" },
            new Quote { Text = "Tragedy is when I cut my finger. Comedy is when you walk into an open sewer and die." , Author = "Mel Brooks" },
            new Quote { Text = "Most people would sooner die than think; in fact, they do so." , Author = "Bertrand Russell" },
            new Quote { Text = "Wit is educated insolence." , Author = "Aristotle" },
            new Quote { Text = "Egotist: a person more interested in himself than in me." , Author = "Ambrose Bierce" },
            new Quote { Text = "The secret of success is to know something nobody else knows." , Author = "Aristotle Onassis" },
            new Quote { Text = "Sometimes when reading Goethe I have the paralyzing suspicion that he is trying to be funny." , Author = "Guy Davenport" },
            new Quote { Text = "After I'm dead I'd rather have people ask why I have no monument than why I have one." , Author = "Cato the Elder" },
            new Quote { Text = "He can compress the most words into the smallest idea of any man I know." , Author = "Abraham Lincoln" },
            // 1390

            new Quote { Text = "When you have to kill a man, it costs nothing to be polite." , Author = "Sir Winston Churchill" },
            new Quote { Text = "Any man who is under 30, and is not a liberal, has not heart; and any man who is over 30, and is not a conservative, has no brains." , Author = "Sir Winston Churchill" },
            new Quote { Text = "The opposite of a correct statement is a false statement. The opposite of a profound truth may well be another profound truth." , Author = "Niels Bohr" },
            new Quote { Text = "We all agree that your theory is crazy, but is it crazy enough?" , Author = "Niels Bohr" },
            new Quote { Text = "When I am working on a problem I never think about beauty. I only think about how to solve the problem. But when I have finished, if the solution is not beautiful, I know it is wrong." , Author = "Buckminster Fuller" },
            new Quote { Text = "In science one tries to tell people, in such a way as to be understood by everyone, something that no one ever knew before. But in poetry, it's the exact opposite." , Author = "Paul Dirac" },
            new Quote { Text = "In any contest between power and patience, bet on patience." , Author = "W.B. Prescott" },
            new Quote { Text = "Anyone who considers arithmetical methods of producing random digits is, of course, in a state of sin." , Author = "John von Neumann" },
            new Quote { Text = "A pint of sweat, saves a gallon of blood." , Author = "General George S. Patton" },
            new Quote { Text = "The mistakes are all waiting to be made." , Author = "chessmaster Savielly Grigorievitch Tartakower" },
            // 1400

            #endregion

            #region 1401 - 1500

            new Quote { Text = "It is unbecoming for young men to utter maxims." , Author = "Aristotle" },
            new Quote { Text = "Grove giveth and Gates taketh away." , Author = "Bob Metcalfe" },
            new Quote { Text = "Denial ain't just a river in Egypt." , Author = "Mark Twain" },
            new Quote { Text = "One of the symptoms of an approaching nervous breakdown is the belief that one's work is terribly important." , Author = "Bertrand Russell" },
            new Quote { Text = "A little inaccuracy sometimes saves a ton of explanation." , Author = "H. H. Munro" },
            new Quote { Text = "What do you take me for, an idiot?" , Author = "Charles de Gaulle, when asked if he was happy" },
            new Quote { Text = "Three o'clock is always too late or too early for anything you want to do." , Author = "Jean-Paul Sartre" },
            new Quote { Text = "A doctor can bury his mistakes but an architect can only advise his clients to plant vines." , Author = "Frank Lloyd Wright" },
            new Quote { Text = "We don't like their sound, and guitar music is on the way out." , Author = "Decca Recording Co. rejecting the Beatles" },
            new Quote { Text = "Everything that can be invented has been invented." , Author = "Charles H. Duell, U.S. Office of Patents" },
            // 1410

            new Quote { Text = "If you haven't got anything nice to say about anybody, come sit next to me." , Author = "Alice Roosevelt Longworth" },
            new Quote { Text = "A man can't be too careful in the choice of his enemies." , Author = "Oscar Wilde" },
            new Quote { Text = "Forgive your enemies, but never forget their names." , Author = "John F. Kennedy" },
            new Quote { Text = "Logic is in the eye of the logician." , Author = "Gloria Steinem" },
            new Quote { Text = "No one can earn a million dollars honestly." , Author = "William Jennings Bryan" },
            new Quote { Text = "Everything has been figured out, except how to live." , Author = "Jean-Paul Sartre" },
            new Quote { Text = "From the moment I picked your book up until I laid it down I was convulsed with laughter. Some day I intend reading it." , Author = "Groucho Marx" },
            new Quote { Text = "It is better to have a permanent income than to be fascinating." , Author = "Oscar Wilde" },
            new Quote { Text = "When ideas fail, words come in very handy." , Author = "Goethe" },
            new Quote { Text = "Who the hell wants to hear actors talk?" , Author = "H.M. Warner, founder of Warner Brothers" },
            // 1420

            new Quote { Text = "In the end, everything is a gag." , Author = "Charlie Chaplin" },
            new Quote { Text = "The nice thing about egotists is that they don't talk about other people." , Author = "Lucille S. Harper" },
            new Quote { Text = "You got to be careful if you don't know where you're going, because you might not get there." , Author = "Yogi Berra" },
            new Quote { Text = "I love Mickey Mouse more than any woman I have ever known." , Author = "Walt Disney" },
            new Quote { Text = "He who hesitates is a damned fool." , Author = "Mae West" },
            new Quote { Text = "Good teaching is one-fourth preparation and three-fourths theater." , Author = "Gail Godwin" },
            new Quote { Text = "University politics are vicious precisely because the stakes are so small." , Author = "Henry Kissinger" },
            new Quote { Text = "The graveyards are full of indispensable men." , Author = "Charles de Gaulle" },
            new Quote { Text = "You can pretend to be serious; you can't pretend to be witty." , Author = "Sacha Guitry" },
            new Quote { Text = "Behind every great fortune there is a crime." , Author = "Honore de Balzac" },
            // 1430

            new Quote { Text = "If women didn't exist, all the money in the world would have no meaning." , Author = "Aristotle Onassis" },
            new Quote { Text = "I am not young enough to know everything." , Author = "Oscar Wilde" },
            new Quote { Text = "The object of war is not to die for your country but to make the other bastard die for his." , Author = "General George Patton" },
            new Quote { Text = "Sometimes a scream is better than a thesis." , Author = "Ralph Waldo Emerson" },
            new Quote { Text = "There is no sincerer love than the love of food." , Author = "George Bernard Shaw" },
            new Quote { Text = "I don't even butter my bread; I consider that cooking." , Author = "Katherine Cebrian" },
            new Quote { Text = "I have an existential map; it has 'you are here' written all over it." , Author = "Steven Wright" },
            new Quote { Text = "Manuscript: something submitted in haste and returned at leisure." , Author = "Oliver Herford" },
            new Quote { Text = "I have read your book and much like it." , Author = "Moses Hadas" },
            new Quote { Text = "The covers of this book are too far apart." , Author = "Ambrose Bierce" },
            // 1440

            new Quote { Text = "Everywhere I go I'm asked if I think the university stifles writers. My opinion is that they don't stifle enough of them." , Author = "Flannery O'Connor" },
            new Quote { Text = "Too many pieces of music finish too long after the end." , Author = "Igor Stravinsky" },
            new Quote { Text = "640K ought to be enough for anybody." , Author = "Bill Gates in 1981" },
            new Quote { Text = "When choosing between two evils, I always like to try the one I've never tried before." , Author = "Mae West" },
            new Quote { Text = "I don't know anything about music. In my line you don't have to." , Author = "Elvis Presley" },
            new Quote { Text = "No Sane man will dance." , Author = "Cicero" },
            new Quote { Text = "Hell is a half-filled auditorium." , Author = "Robert Frost" },
            new Quote { Text = "Show me a sane man and I will cure him for you." , Author = "Carl Gustav Jung" },
            new Quote { Text = "If I were two-faced, would I be wearing this one?" , Author = "Abraham Lincoln" },
            new Quote { Text = "There is no reason anyone would want a computer in their home." , Author = "Ken Olson" },
            // 1450

            new Quote { Text = "Hell is other people." , Author = "Jean-Paul Sartre" },
            new Quote { Text = "I am become death, shatterer of worlds." , Author = "Robert J. Oppenheimer" },
            new Quote { Text = "Happiness is good health and a bad memory." , Author = "Ingrid Bergman" },
            new Quote { Text = "Friends may come and go, but enemies accumulate." , Author = "Thomas Jones" },
            new Quote { Text = "You can get more with a kind word and a gun than you can with a kind word alone." , Author = "Al Capone" },
            new Quote { Text = "The gods too are fond of a joke." , Author = "Aristotle" },
            new Quote { Text = "Distrust any enterprise that requires new clothes." , Author = "Henry David Thoreau" },
            new Quote { Text = "Democracy does not guarantee equality of conditions - it only guarantees equality of opportunity." , Author = "Irving Kristol" },
            new Quote { Text = "It is time I stepped aside for a less experienced and less able man." , Author = "Professor Scott Elledge on his retirement from Cornell" },
            new Quote { Text = "Every day I get up and look through the Forbes list of the richest people in America. If I'm not there, I go to work." , Author = "Robert Orben" },
            // 1460

            new Quote { Text = "The cynics are right nine times out of ten." , Author = "Henry Louis Mencken" },
            new Quote { Text = "There are some experiences in life which should not be demanded twice from any man, and one of them is listening to the Brahms Requiem." , Author = "George Bernard Shaw" },
            new Quote { Text = "Attention to health is life's greatest hindrance." , Author = "Plato" },
            new Quote { Text = "Plato was a bore." , Author = "Friedrich Nietzsche" },
            new Quote { Text = "Nietzsche was stupid and abnormal." , Author = "Leo Tolstoy" },
            new Quote { Text = "I'm not going to get into the ring with Tolstoy." , Author = "Ernest Hemingway" },
            new Quote { Text = "Hemingway was a jerk." , Author = "Harold Robbins" },
            new Quote { Text = "How can I lose to such an idiot?" , Author = "A shout from chessmaster Aaron Nimzovich" },
            new Quote { Text = "I don't feel good." , Author = "Dying words of Luther Burbank" },
            new Quote { Text = "Nothing is wrong with California that a rise in the ocean level wouldn't cure." , Author = "Ross MacDonald" },
            // 1470

            new Quote { Text = "Men have become the tools of their tools." , Author = "Henry David Thoreau" },
            new Quote { Text = "I have never let my schooling interfere with my education." , Author = "Mark Twain" },
            new Quote { Text = "It is now possible for a flight attendant to get a pilot pregnant." , Author = "Richard J. Ferris" },
            new Quote { Text = "I don't want to achieve immortality through my work; I want to achieve immortality through not dying." , Author = "Woody Allen" },
            new Quote { Text = "Men and nations behave wisely once they have exhausted all the other alternatives." , Author = "Abba Eban" },
            new Quote { Text = "To sit alone with my conscience will be judgment enough for me." , Author = "Charles William Stubbs" },
            new Quote { Text = "Sanity is a madness put to good uses." , Author = "George Santayana" },
            new Quote { Text = "Imitation is the sincerest form of television." , Author = "Fred Allen" },
            new Quote { Text = "Always do right- this will gratify some and astonish the rest." , Author = "Mark Twain" },
            new Quote { Text = "The backbone of surprise is fusing speed with secrecy." , Author = "Von Clausewitz" },
            // 1480

            new Quote { Text = "In America, anybody can be president. That's one of the risks you take." , Author = "Adlai Stevenson" },
            new Quote { Text = "Copy from one, it's plagiarism; copy from two, it's research." , Author = "Wilson Mizner" },
            new Quote { Text = "Why don't you write books people can read?" , Author = "Nora Joyce to her husband James" },
            new Quote { Text = "Some editors are failed writers, but so are most writers." , Author = "T. S. Eliot" },
            new Quote { Text = "Criticism is prejudice made plausible." , Author = "Henry Louis Mencken" },
            new Quote { Text = "It is better to be quotable than to be honest." , Author = "Tom Stoppard" },
            new Quote { Text = "Being on the tightrope is living; everything else is waiting." , Author = "Karl Wallenda" },
            new Quote { Text = "Opportunities multiply as they are seized." , Author = "Sun Tzu" },
            new Quote { Text = "A scholar who cherishes the love of comfort is not fit to be deemed a scholar." , Author = "Lao-Tzu" },
            new Quote { Text = "The best way to predict the future is to invent it." , Author = "Alan Kay" },
            // 1490

            new Quote { Text = "Never mistake motion for action." , Author = "Ernest Hemingway" },
            new Quote { Text = "Hell is paved with good samaritans." , Author = "William M. Holden" },
            new Quote { Text = "The longer I live the more I see that I am never wrong about anything, and that all the pains that I have so humbly taken to verify my notions have only wasted my time." , Author = "George Bernard Shaw" },
            new Quote { Text = "Well done is better than well said." , Author = "Benjamin Franklin" },
            new Quote { Text = "The average person thinks he isn't." , Author = "Father Larry Lorenzoni" },
            new Quote { Text = "Heav'n hath no rage like love to hatred turn'd, nor hell a fury, like a woman scorn'd." , Author = "William Congreve" },
            new Quote { Text = "A husband is what is left of the lover after the nerve has been extracted." , Author = "Helen Rowland" },
            new Quote { Text = "Learning is what most adults will do for a living in the 21st century." , Author = "Perelman" },
            new Quote { Text = "The man who goes alone can start today; but he who travels with another must wait till that other is ready.", Author = "Henry David Thoreau" },
            new Quote { Text = "There is a country in Europe where multiple-choice tests are illegal." , Author = "Sigfried Hulzer" },
            // 1500

            #endregion

            #region 1501 -

            new Quote { Text = "Ask her to wait a moment - I am almost done." , Author = "Carl Friedrich Gauss, while working, when informed that his wife is dying" },
            new Quote { Text = "A pessimist sees the difficulty in every opportunity; an optimist sees the opportunity in every difficulty." , Author = "Sir Winston Churchill" },
            new Quote { Text = "I think there is a world market for maybe five computers." , Author = "Thomas Watson, Chairman of IBM" },
            new Quote { Text = "I think it would be a good idea." , Author = "Mahatma Gandhi, when asked what he thought of Western civilization" },
            new Quote { Text = "The only thing necessary for the triumph of evil is for good men to do nothing." , Author = "Edmund Burke" },
            new Quote { Text = "I'm not a member of any organized political party, I'm a Democrat!" , Author = "Will Rogers" },
            new Quote { Text = "If Stupidity got us into this mess, then why can't it get us out?" , Author = "Will Rogers" },

            #endregion
        };


        public static string GetRandomWowza()
        {
            int i = random.Next(8);
            switch(i)
            {
                case 0: return "WOWZA!";
                case 1: return "COOL!";
                case 2: return "NICE!";
                case 3: return "NICE ONE!";
                case 4: return "AWESOME!";
                case 5: return "WAY TO GO!";
                case 6: return "IN THE BAG!";
                default: return "NAILED!";
            }
        }


        public static Quote GetRandomQuote()
        {
            int i = random.Next(Quotes.Count);
            return Quotes[i];
        }
    }
}
