using PPE_MISSION_2_MAISON_DES_LIGUES;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestVerifUtilisateur
{
    
    
    /// <summary>
    ///Classe de test pour adherentDAOTest, destinée à contenir tous
    ///les tests unitaires adherentDAOTest
    ///</summary>
    [TestClass()]
    public class adherentDAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour verifUtilisateur
        ///</summary>
        [TestMethod()]
        public void verifUtilisateurTest()
        {
            adherentDAO target = new adherentDAO(); // TODO: initialisez à une valeur appropriée
            string login = "marco"; // TODO: initialisez à une valeur appropriée
            string mdp = "marco"; // TODO: initialisez à une valeur appropriée
            int pGrade = 1; // TODO: initialisez à une valeur appropriée
            int pGradeExpected = 1; // TODO: initialisez à une valeur appropriée
            int pId = 11; // TODO: initialisez à une valeur appropriée
            int pIdExpected = 10; // TODO: initialisez à une valeur appropriée
            bool expected = true; // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.verifUtilisateur(login, mdp, out pGrade, out pId);
            Assert.AreEqual(pGradeExpected, pGrade);
            Assert.AreEqual(pIdExpected, pId);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
