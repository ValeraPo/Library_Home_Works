using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Library_Home_Works.Tests
{
    public class HomeWork_6Tests
    {
        //Задание 1
        public enum AlternateSignOnEdgesMockVariants { Matrix0x0, Matrix1x1, Matrix3x3, Matrix3x5, Matrix4x9 }
        public static int[,] AlternateSignOnEdgesMockInputData(AlternateSignOnEdgesMockVariants matrix)
        {
            switch (matrix)
            {
                case AlternateSignOnEdgesMockVariants.Matrix0x0:
                    return new int[0, 0];
                case AlternateSignOnEdgesMockVariants.Matrix1x1:
                    return new int[1, 1] { { 1 } };
                case AlternateSignOnEdgesMockVariants.Matrix3x3:
                    return new int[3, 3] {
                        { 0, 1, -5 },
                        { -3, 4, 6 },
                        { 2, 4, -7 } };
                case AlternateSignOnEdgesMockVariants.Matrix3x5:
                    return new int[3, 5] {
                        { -50, 86, -40, 24, 30 },
                        { -96, 24, 82, -89, -23 },
                        { 24, 3, -85, 80, -29 } };
                case AlternateSignOnEdgesMockVariants.Matrix4x9:
                    return new int[4, 9] {
                        { 8, -32, 15, 2, -61, -8, -87, -63, 77 },
                        { 58, 88, -68, 68, 50, 52, -41, 53, -17 },
                        { 58, 9, -74, -2, 12, -92, 7, -22, 54 },
                        { 48, 42, -65, 22, 24, 68, -97, 22, 49 } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
        public static int[,] AlternateSignOnEdgesMockOutputData(AlternateSignOnEdgesMockVariants matrix)
        {
            switch (matrix)
            {
                case AlternateSignOnEdgesMockVariants.Matrix0x0:
                    return new int[0, 0];
                case AlternateSignOnEdgesMockVariants.Matrix1x1:
                    return new int[1, 1] { { -1 } };
                case AlternateSignOnEdgesMockVariants.Matrix3x3:
                    return new int[3, 3] {
                        { 0, -1, 5 },
                        { 3, 4, -6 },
                        { -2, -4, 7 } };
                case AlternateSignOnEdgesMockVariants.Matrix3x5:
                    return new int[3, 5] {
                        { 50, -86, 40, -24, -30 },
                        { 96, 24, 82, -89, 23 },
                        { -24, -3, 85, -80, 29 } };
                case AlternateSignOnEdgesMockVariants.Matrix4x9:
                    return new int[4, 9] {
                        { -8, 32, -15, -2, 61, 8, 87, 63, -77 },
                        { -58, 88, -68, 68, 50, 52, -41, 53, 17 },
                        { -58, 9, -74, -2, 12, -92, 7, -22, -54 },
                        { -48, -42, 65, -22, -24, -68, 97, -22, -49 } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
    
        [TestCase(AlternateSignOnEdgesMockVariants.Matrix0x0)]
        [TestCase(AlternateSignOnEdgesMockVariants.Matrix1x1)]
        [TestCase(AlternateSignOnEdgesMockVariants.Matrix3x3)]
        [TestCase(AlternateSignOnEdgesMockVariants.Matrix3x5)]
        [TestCase(AlternateSignOnEdgesMockVariants.Matrix4x9)]
        public void AlternateSignOnEdgesTest(AlternateSignOnEdgesMockVariants matrix)
        {
            int[,] expected = AlternateSignOnEdgesMockOutputData(matrix);
            int[,] actual = HomeWork_6.AlternateSignOnEdges(AlternateSignOnEdgesMockInputData(matrix));
            Assert.AreEqual(expected, actual);
        }
        // Задание 2
        public static int[,] MultTableOutputData()
        {
            return new int[,] {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 2, 4, 6, 8, 10, 12, 14, 16, 18 },
                { 3, 6, 9, 12, 15, 18, 21, 24, 27 }, 
                { 4, 8, 12, 16, 20, 24, 28, 32, 36 }, 
                { 5, 10, 15, 20, 25, 30, 35, 40, 45 },
                { 6, 12, 18, 24, 30, 36, 42, 48, 54 }, 
                { 7, 14, 21, 28, 35, 42, 49, 56, 63 }, 
                { 8, 16, 24, 32, 40, 48, 56, 64, 72 }, 
                { 9, 18, 27, 36, 45, 54, 63, 72, 81 } };
        }
        public void MultTableTest()
        {
            int[,] actual = HomeWork_6.MultTable();
            int[,] expected = MultTableOutputData();
            Assert.AreEqual(expected, actual);
        }
        //Задание 3
        
        public static int[,] ChessDeskOutputData(int size)
        {
            switch (size)
            {
                case 1:
                    return new int[1, 1] { { 0 } }; 
                case 2:
                    return new int[2, 2] {
                        { 1, 0, },
                        { 0, 1, } };
                    
                case 3:
                    return new int[3, 3] {
                        { 0, 1, 0, },
                        { 1, 0, 1, },
                        { 0, 1, 0,  } };
                case 5:
                    return new int[5, 5] {
                        { 0, 1, 0, 1, 0, },
                        { 1, 0, 1, 0, 1, },
                        { 0, 1, 0, 1, 0, },
                        { 1, 0, 1, 0, 1, },
                        { 0, 1, 0, 1, 0, } };
                case 10:
                    return new int[10, 10] {
                        { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, },
                        { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, },
                        { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, },
                        { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, },
                        { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, },
                        { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, },
                        { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, },
                        { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, },
                        { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, },
                        { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(10)]
        public void ChessDeskTest(int size)
        {
            int[,] actual = HomeWork_6.ChessDesk(size);
            int[,] expected = ChessDeskOutputData(size);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-10)]
        public void ChessDeskNegativeTest(int size)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_6.ChessDesk(size));
        }
        // Задание 4
        public enum CheckCovidRulesMockVariants { Matrix0x0, Matrix1x1, Matrix3x3, Matrix3x5, Matrix4x9, MatrixError }
        public static int[,] CheckCovidRulesMockInputData(CheckCovidRulesMockVariants matrix)
        {
            switch (matrix)
            {
                case CheckCovidRulesMockVariants.Matrix0x0:
                    return new int[0, 0];
                case CheckCovidRulesMockVariants.Matrix1x1:
                    return new int[1, 1] { { 1 } };
                case CheckCovidRulesMockVariants.Matrix3x3:
                    return new int[3, 3] {
                        { 0, 1, 0 },
                        { 1, 0, 1 },
                        { 0, 1, 0 } };
                case CheckCovidRulesMockVariants.Matrix3x5:
                    return new int[3, 5] {
                        { 0, 0, 0, 0, 0 },
                        { 0, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0 } };
                case CheckCovidRulesMockVariants.Matrix4x9:
                    return new int[4, 9] {
                        { 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 0, 1, 1 } };
                case CheckCovidRulesMockVariants.MatrixError:
                    return new int[3, 5] {
                        { 50, -86, 40, -24, -30 },
                        { 96, 24, 82, -89, 23 },
                        { -24, -3, 85, -80, 29 } }; 
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
        [TestCase(CheckCovidRulesMockVariants.Matrix0x0, true)]
        [TestCase(CheckCovidRulesMockVariants.Matrix1x1, true)]
        [TestCase(CheckCovidRulesMockVariants.Matrix3x3, true)]
        [TestCase(CheckCovidRulesMockVariants.Matrix3x5, false)]
        [TestCase(CheckCovidRulesMockVariants.Matrix4x9, false)]
        public void CheckCovidRulesTest(CheckCovidRulesMockVariants matrix, bool expected)
        {
            bool actual = HomeWork_6.CheckCovidRules(CheckCovidRulesMockInputData(matrix));
            Assert.AreEqual(expected, actual);
        }
        [TestCase(CheckCovidRulesMockVariants.MatrixError)]
        public void CheckCovidNegativeRulesTest(CheckCovidRulesMockVariants matrix)
        {
            int[,] expected = CheckCovidRulesMockInputData(matrix);
            Assert.Throws<System.ArgumentException>(() => HomeWork_6.CheckCovidRules(expected));
        }
        // Задание 5
        public enum GetSumMiddleMinMaxIncomeMockVariants { Matrix1, Matrix2, Matrix3, Matrix4, Matrix5, MatrixError }
        public static double[,] GetSumMiddleMinMaxIncomeMockInputData(GetSumMiddleMinMaxIncomeMockVariants matrix)
        {
            switch (matrix)
            {
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix1:
                    return new double[10, 6] {
                        { 180.12475882662682, 452.10104968962304, 260.8739925831901, 140.81386390180043, 936.1974601336743, 703.4408509281654 },
                        { 489.82018534551383, 513.2390142014432, 676.6641571543478, 620.39947818052, 887.1026220205717, 319.74666906508924 },
                        { 942.0243459483721, 307.0102172470699, 631.262550424441, 560.2122273110841, 380.9736968860839, 296.415749609664 },
                        { 161.5035669698862, 696.9687611316185, 270.20470717465724, 855.5535906253167, 735.0041548418832, 18.59739656494809 },
                        { 870.8691414775649, 224.52847856307798, 472.9988623750391, 137.6487021975446, 892.7091718151743, 716.2169705686239 },
                        { 75.18877930715158, 231.06964734898398, 549.8032199916445, 959.2353608269409, 693.0255460054733, 534.7017946349 },
                        { 32.09609260414545, 906.91818339141, 492.5745439215445, 63.851199142565584, 945.6414542839125, 215.73538808884814 },
                        { 277.9149786931998, 553.4341612613919, 947.6479375491142, 842.8077478161118, 945.9477704697978, 643.0645019947851 },
                        { 767.1297475542545, 440.9885608782007, 224.83620104605157, 473.781153314645, 219.88005946384746, 451.6332412379017 },
                        { 592.6294464583646, 324.5711682013102, 717.0968948477399, 242.276596018242, 269.9447224242355, 711.6689815705963 } };
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix2:
                    return new double[10, 6] {
                        { 230.44198855312635, 352.17148314796924, 620.5298423862689, 960.4471865857239, 545.2106988733684, 656.0329746715878 },
                        { 769.9434490734448, 982.7889851214313, 613.9846712415966, 96.56075578954106, 528.1161347069387, 474.0555134946739 },
                        { 803.8412056881194, 97.65236782732065, 751.3273068477062, 54.46931908580908, 577.6386119321169, 181.56999358049129 },
                        { 70.9494590158339, 28.061393661453103, 278.5807080932803, 829.9343603802539, 370.51895464329, 451.7206109369735 },
                        { 491.38076952257234, 601.4076259925065, 11.189587885136524, 98.16997875374275, 366.6059143685763, 368.4543778041631 },
                        { 817.6048997871601, 789.8194965859035, 636.9734609671744, 780.9055623509481, 833.4092105894393, 593.4699711359432 },
                        { 595.2055457025792, 317.4677921074758, 8.223462388023483, 291.6149628775264, 72.86429874266697, 963.1587853483665 },
                        { 29.079830753188503, 670.5689917647135, 912.872426171262, 750.7806875513776, 669.9399476265255, 122.22769163652681 },
                        { 700.3059343901956, 538.1601273725555, 746.9325562691934, 535.5269012672487, 171.32713700240808, 241.88332876278244 },
                        { 433.088273477316, 400.5076281728724, 981.6525285046793, 168.80923144929542, 469.0664170631517, 943.8030728808618 }};
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix3:
                    return new double[10, 6] {
                        { 644.8433867864512, 671.773470319702, 616.183070752855, 245.53029343743358, 278.955856002381, 738.2966381210352 },
                        { 837.0820525274994, 22.93564333717136, 264.2431572378814, 157.85733571176294, 459.2637733832299, 260.170819824641 },
                        { 173.34653119246778, 779.3344961383075, 955.1970949187861, 315.42192274491396, 800.8545296270654, 699.9499628785765 },
                        { 538.8481847657115, 740.6000819711946, 931.4676783659811, 888.9618962486097, 397.8640443635472, 828.4457869960207 },
                        { 621.5218215349697, 282.07799851991143, 618.4923595834954, 395.09013220439203, 347.8172888736321, 432.90158241656684 },
                        { 611.8174426312639, 426.39631425328383, 848.4013750443241, 64.42038950716164, 646.7715760910752, 401.09082842296493 },
                        { 346.9757145955114, 783.549537315755, 391.61313576233255, 174.57578805022678, 913.6986350238783, 647.0043042893542 },
                        { 857.9845343986455, 542.4485986784326, 78.89635398932562, 486.7617364445523, 362.1803700747808, 391.9926408641006 },
                        { 286.68623384399626, 117.66635073240211, 599.653098545807, 281.70256562610274, 629.9610466835838, 728.466335091957 },
                        { 12.335394514880791, 755.8814905378416, 273.9094259561549, 787.7372837568341, 624.0084719024637, 996.8778574824696 } };
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix4:
                    return new double[10, 6] {
                        { 119.8042785375399, 441.99192032310737, 675.1183544635393, 831.3415748213146, 546.0398930804989, 32.867459129946056 },
                        { 411.76944478031686, 108.92614168530616, 132.56292004723238, 554.1062664958212, 968.4462081494025, 17.304992311310485 },
                        { 308.33682711624397, 364.2723967154847, 826.9014469473163, 284.4633740766269, 30.9773618499643, 855.4154456851144 },
                        { 749.5494330066952, 134.76008509041745, 919.8976284451305, 226.49971871939476, 108.40389836039576, 230.15093814123 },
                        { 833.2484838707597, 330.1148770051612, 796.4352675696999, 119.93503995236709, 52.08499499228084, 890.8900855532336 },
                        { 127.18140246681003, 559.2384308386773, 159.54106541329114, 394.735278279863, 54.771509512686876, 471.70671470077093 },
                        { 971.8859498258149, 26.642959577330835, 996.4087055979337, 46.02889485937958, 74.99229166423544, 253.25422838947463 },
                        { 259.4297208168682, 732.579967348175, 149.2201425829996, 582.3481062344965, 973.3657385098588, 265.6886499680991 },
                        { 901.5648881446407, 727.8720204382539, 724.9041286878772, 418.49398027104047, 38.187850750138914, 489.24838681204636 },
                        { 76.98022903733897, 893.3045598181452, 333.5880219627116, 444.96741632230925, 998.0930909505547, 215.9250160753378 }};
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix5:
                    return new double[10, 6] {
                        { 236.43219156024614, 291.83440482794975, 56.84114669302532, 241.6728344939988, 426.92486402901113, 409.2077773107252, },
                        { 857.7639268980193, 913.601548836381, 309.5008872027979, 355.19473224654547, 312.577424250812, 4.334402272633464 },
                        { 859.0067400871807, 703.5205381473156, 59.767793426182024, 666.6434000556559, 967.0699979025266, 375.82393101222067 },
                        { 80.93079555823039, 250.90037763626333, 356.74913849530236, 530.7466176016007, 218.37015180772642, 324.21297455402697 },
                        { 165.9859568653563, 708.6874221957695, 521.0505800885385, 670.2926786012448, 317.755049242524, 161.46694969454174 },
                        { 138.1186927380593, 526.9185335035057, 28.54986862677609, 780.4836895225959, 809.5967032991334, 783.1578868362856 },
                        { 196.41308169644935, 17.756886322869402, 305.65510331916397, 740.0123652722745, 724.5841793364771, 59.76418967347787 },
                        { 956.1877627653013, 546.3701558980953, 415.2945961874419, 720.5697264152437, 559.4872401838597, 334.6673126028233 },
                        { 429.4805933858643, 410.336828981683, 926.2345619156185, 957.764090950491, 364.03662076407886, 747.1927133142914 },
                        { 859.1758775800355, 705.6855739586454, 73.46425302022334, 732.6281721389984, 75.68687762864253, 718.2374418332415 }};
                case GetSumMiddleMinMaxIncomeMockVariants.MatrixError:
                    return new double[3, 3] {
                        { 630.1983956388191, 98.85784988238376, 18.409505960722225 },
                        { 59.844334637673725, 578.6950460535917, 913.8716584601774 },
                        { 179.86655709327505, 659.26787986386, 93.24085903039241 } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
        public static (double[], double[], double, double) GetSumMiddleMinMaxIncomeMockOutputData(
                                                            GetSumMiddleMinMaxIncomeMockVariants matrix)
        {
            switch (matrix)
            {
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix1:
                    return (
                       new double[] { 2673.55, 3506.97, 3117.9, 2737.83, 3314.97, 3043.02, 2656.82, 4210.82, 
                                      2578.25, 2858.19 },
                       new double[] { 731.55, 775.14, 873.99, 816.1, 1151.07, 768.54 }, 18.6, 959.24) ;
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix2:
                    return (
                        new double[] { 3364.83, 3465.45, 2466.5, 2029.77, 1937.21, 4452.18, 2248.53, 3155.47, 
                                       2934.14, 3396.93, },
                        new double[] { 823.64, 796.43, 927.04, 761.2, 767.45, 832.73, }, 8.22, 982.79);
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix3:
                    return (
                        new double[] { 3195.58, 2001.55, 3724.1, 4326.19, 2697.9, 2998.9, 3257.42, 
                                       2720.26, 2644.14, 3450.75, },
                        new double[] { 821.91, 853.78, 929.68, 633.01, 910.23, 1020.87, }, 12.34, 996.88);
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix4:
                    return (
                       new double[] { 2647.16, 2193.12, 2670.37, 2369.26, 3022.71, 1767.17, 2369.21, 
                                      2962.63, 3300.27, 2962.86, },
                       new double[] { 793.29, 719.95, 952.43, 650.49, 640.89, 620.41, }, 17.3, 998.09);
                case GetSumMiddleMinMaxIncomeMockVariants.Matrix5:
                    return (
                         new double[] { 1662.91, 2752.97, 3631.83, 1761.91, 2545.24, 3066.83, 2044.19, 
                                        3532.58, 3835.05, 3164.88, },
                         new double[] { 796.58, 845.94, 508.85, 1066, 796.01, 653.01, }, 4.33, 967.07);
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
        [TestCase(GetSumMiddleMinMaxIncomeMockVariants.Matrix1)]
        [TestCase(GetSumMiddleMinMaxIncomeMockVariants.Matrix2)]
        [TestCase(GetSumMiddleMinMaxIncomeMockVariants.Matrix3)]
        [TestCase(GetSumMiddleMinMaxIncomeMockVariants.Matrix4)]
        [TestCase(GetSumMiddleMinMaxIncomeMockVariants.Matrix5)]
        public void GetSumMiddleMinMaxIncomeTest(GetSumMiddleMinMaxIncomeMockVariants matrix)
        {
            (double[], double[], double, double) expected = GetSumMiddleMinMaxIncomeMockOutputData(matrix);
            (double[], double[], double, double) actual = HomeWork_6.GetSumMiddleMinMaxIncome(
                                                            GetSumMiddleMinMaxIncomeMockInputData(matrix));
            Assert.AreEqual(expected, actual);
        }
        [TestCase(GetSumMiddleMinMaxIncomeMockVariants.MatrixError)]
        public void GetSumMiddleMinMaxIncomeNegativeTest(GetSumMiddleMinMaxIncomeMockVariants matrix)
        {
            double[,] expected = GetSumMiddleMinMaxIncomeMockInputData(matrix);
            Assert.Throws<System.ArgumentException>(() => HomeWork_6.GetSumMiddleMinMaxIncome(expected));
        }
        //Задание 6
        public enum SearchElemMoreNeighboursMockVariants { Matrix0x0, Matrix1x1, Matrix3x3, Matrix3x5, Matrix4x9 }
        public static int[,] SearchElemMoreNeighboursMockInputData(SearchElemMoreNeighboursMockVariants matrix)
        {
            switch (matrix)
            {
                case SearchElemMoreNeighboursMockVariants.Matrix0x0:
                    return new int[0, 0];
                case SearchElemMoreNeighboursMockVariants.Matrix1x1:
                    return new int[1, 1] { { 1 } };
                case SearchElemMoreNeighboursMockVariants.Matrix3x3:
                    return new int[3, 3] {
                        { 0, 1, -5 },
                        { -3, 4, 6 },
                        { 2, 4, -7 } };
                case SearchElemMoreNeighboursMockVariants.Matrix3x5:
                    return new int[3, 5] {
                        { -50, 86, -40, 24, 30 },
                        { -96, 24, 82, -89, -23 },
                        { 24, 3, -85, 80, -29 } };
                case SearchElemMoreNeighboursMockVariants.Matrix4x9:
                    return new int[4, 9] {
                        { 8, -32, 15, 2, -61, -8, -87, -63, 77 },
                        { 58, 88, -68, 68, 50, 52, -41, 53, -17 },
                        { 58, 9, -74, -2, 12, -92, 7, -22, 54 },
                        { 48, 42, -65, 22, 24, 68, -97, 22, 49 } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
        [TestCase(CheckCovidRulesMockVariants.Matrix0x0, 0)]
        [TestCase(CheckCovidRulesMockVariants.Matrix1x1, 1)]
        [TestCase(CheckCovidRulesMockVariants.Matrix3x3, 5)]
        [TestCase(CheckCovidRulesMockVariants.Matrix3x5, 8)]
        [TestCase(CheckCovidRulesMockVariants.Matrix4x9, 16)]
        public void SearchElemMoreNeighboursTest(SearchElemMoreNeighboursMockVariants matrix, int expected)
        {
            int actual = HomeWork_6.SearchElemMoreNeighbours(SearchElemMoreNeighboursMockInputData(matrix));
            Assert.AreEqual(expected, actual);
        }
        //Задание 7
        public static char[,] SandWatchOutputData(int size)
        {
            switch (size)
            {
                case 3:
                    return new char[3, 3] {
                    { '1', '1', '1' },
                    { '0', '1', '0' },
                    { '1', '1', '1' }};
                case 4:
                    return new char[4, 4] {
                        { '1', '1', '1', '1' },
                        { '0', '1', '1', '0' },
                        { '0', '1', '1', '0' },
                        { '1', '1', '1', '1' } };
                case 5:
                    return new char[5, 5] {
                        { '1', '1', '1', '1', '1' },
                        { '0', '1', '1', '1', '0' },
                        { '0', '0', '1', '0', '0' },
                        { '0', '1', '1', '1', '0' },
                        { '1', '1', '1', '1', '1' } };
                case 7:
                    return new char[7, 7] {
                        { '1', '1', '1', '1', '1', '1', '1' },
                        { '0', '1', '1', '1', '1', '1', '0' },
                        { '0', '0', '1', '1', '1', '0', '0' },
                        { '0', '0', '0', '1', '0', '0', '0' },
                        { '0', '0', '1', '1', '1', '0', '0' },
                        { '0', '1', '1', '1', '1', '1', '0' },
                        { '1', '1', '1', '1', '1', '1', '1' } };
                case 10:
                    return new char[10, 10] {
                        { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                        { '0', '1', '1', '1', '1', '1', '1', '1', '1', '0' },
                        { '0', '0', '1', '1', '1', '1', '1', '1', '0', '0' },
                        { '0', '0', '0', '1', '1', '1', '1', '0', '0', '0' },
                        { '0', '0', '0', '0', '1', '1', '0', '0', '0', '0' },
                        { '0', '0', '0', '0', '1', '1', '0', '0', '0', '0' },
                        { '0', '0', '0', '1', '1', '1', '1', '0', '0', '0' },
                        { '0', '0', '1', '1', '1', '1', '1', '1', '0', '0' },
                        { '0', '1', '1', '1', '1', '1', '1', '1', '1', '0' },
                        { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }

        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(10)]
        public void SandWatchTest(int size)
        {
            char[,] actual = HomeWork_6.SandWatch(size);
            char[,] expected = SandWatchOutputData(size);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-10)]
        public void SandWatchNegativeTest(int size)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_6.SandWatch(size));
        }
        //Задание 8
        public enum MatrixMultMockVariants { Matrix3x1, Matrix4x1, Matrix2x3, Matrix3x3, Matrix4x3 }
        public static int[,] MatrixMultMockInputData(MatrixMultMockVariants matrix)
        {
            switch (matrix)
            {
                case MatrixMultMockVariants.Matrix3x1:
                    return new int[3, 1] { { 2 }, { -3 }, { 10 } };
                case MatrixMultMockVariants.Matrix2x3:
                    return new int[2, 3] { 
                        { 4, -5, 45}, 
                        { -9, 18, 7} };
                case MatrixMultMockVariants.Matrix3x3:
                    return new int[3, 3] {
                        { 0, 1, -5 },
                        { -3, 4, 6 },
                        { 2, 4, -7 } };
                case MatrixMultMockVariants.Matrix4x3:
                    return new int[4, 3] {
                        { 8, -32, 15 },
                        { 58, 88, -68 },
                        { 58, 9, -74 },
                        { 48, 42, -65 } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }
        public static int[,] MatrixMultMockOutputData(MatrixMultMockVariants matrix)
        {
            switch (matrix)
            {
                case MatrixMultMockVariants.Matrix4x1:
                    return new int[4, 1] {
                        { 262 },
                        { -828 },
                        { -651 },
                        { -680 } }; 
                case MatrixMultMockVariants.Matrix2x3:
                    return new int[2, 3] {
                        { 105, 164, -365},
                        { -40, 91, 104} };
                case MatrixMultMockVariants.Matrix3x3:
                    return new int[3, 3] {
                        { -13, -16, 41 },
                        { 0, 37, -3 },
                        { -26, -10, 63 } };
                case MatrixMultMockVariants.Matrix4x3:
                    return new int[4, 3] {
                        { 126, -60, -337 },
                        { -400, 138, 714 },
                        { -175, -202, 282 },
                        { -256, -44, 467 } };
                case MatrixMultMockVariants.Matrix3x1:
                    return new int[3, 1] {
                        { -53 },
                        { 42 },
                        { -78 } };
                default: throw new ArgumentException("Несуществующий параметр");
            }
        }

        [TestCase(MatrixMultMockVariants.Matrix3x3, MatrixMultMockVariants.Matrix3x3, MatrixMultMockVariants.Matrix3x3)]
        [TestCase(MatrixMultMockVariants.Matrix4x3, MatrixMultMockVariants.Matrix3x1, MatrixMultMockVariants.Matrix4x1)]
        [TestCase(MatrixMultMockVariants.Matrix2x3, MatrixMultMockVariants.Matrix3x3, MatrixMultMockVariants.Matrix2x3)]
        [TestCase(MatrixMultMockVariants.Matrix4x3, MatrixMultMockVariants.Matrix3x3, MatrixMultMockVariants.Matrix4x3)]
        [TestCase(MatrixMultMockVariants.Matrix3x3, MatrixMultMockVariants.Matrix3x1, MatrixMultMockVariants.Matrix3x1)]
        public void MatrixMultTest(MatrixMultMockVariants matrix1, MatrixMultMockVariants matrix2, 
                                   MatrixMultMockVariants matrix3)
        {
            int[,] expected = MatrixMultMockOutputData(matrix3);
            int[,] actual = HomeWork_6.MatrixMult(MatrixMultMockInputData(matrix1), (int[,])MatrixMultMockInputData(matrix2));
            Assert.AreEqual(expected, actual);
        }
        [TestCase(MatrixMultMockVariants.Matrix2x3, MatrixMultMockVariants.Matrix4x3)]
        [TestCase(MatrixMultMockVariants.Matrix3x1, MatrixMultMockVariants.Matrix4x3)]
        [TestCase(MatrixMultMockVariants.Matrix3x3, MatrixMultMockVariants.Matrix2x3)]
        public void MatrixMultNegativeTest(MatrixMultMockVariants matrix1, MatrixMultMockVariants matrix2)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_6.MatrixMult(MatrixMultMockInputData(matrix1), 
                                                                                MatrixMultMockInputData(matrix2)));
        }
    }
}
