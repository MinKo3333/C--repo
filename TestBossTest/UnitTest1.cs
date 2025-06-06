
    using NUnit.Framework;
    using TestBossTest;

    namespace TestBossFight
 {
     public class Tests
     {
            [Test]
            public void TestValidInitialization()
            {
            var expectedHealth = 100;
                var expectedStrength = 20;
                var expectedStamina = 40;
                GameCharacter gameCharacter = new GameCharacter( expectedHealth, expectedStrength , expectedStamina);
                Assert.AreEqual(gameCharacter.Strength, expectedStrength);
                Assert.AreEqual(gameCharacter.Stamina, expectedStamina);
                Assert.AreEqual(gameCharacter.Health, expectedHealth);
            }

            [Test]
            public void TestFightTakesEnemyHealth()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);
                var expectedBossHealthAfterFight = 380;
                var expectedHeroHealthAfterFight = 80;

                hero.Fight(boss);
                boss.Fight(hero);

                Assert.AreEqual(boss.Health, expectedBossHealthAfterFight);
                Assert.AreEqual(hero.Health, expectedHeroHealthAfterFight);
            }

            [Test]
            public void TestDrainStamina()
            {
                GameCharacter hero = new GameCharacter(100, 20, 40);

                hero.DrainStamina(30);

                Assert.AreEqual(hero.Stamina, 10);
            }

            [Test]
            public void TestStaminaLossAfterFight()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);

                var expectedBossStaminaAfterFight = 0;
                var expectedHeroStaminaAfterFight = 30;

                boss.Fight(hero);
                hero.Fight(boss);

                Assert.AreEqual(boss.Stamina, expectedBossStaminaAfterFight);
                Assert.AreEqual(hero.Stamina, expectedHeroStaminaAfterFight);
            }

            [Test]
            public void TestRechargeBoss()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);

                boss.DrainStamina(10);

                var expectedBossStaminaAfterRecharge = 10;
                boss.Recharge();

                Assert.AreEqual(boss.Stamina, expectedBossStaminaAfterRecharge);
            }

            [Test]
            public void TestRechargeHero()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);

                hero.DrainStamina(40);

                var expectedHeroStaminaAfterRecharge = 40;
                hero.Recharge();

                Assert.AreEqual(hero.Stamina, expectedHeroStaminaAfterRecharge);
            }


            [Test]
            public void TestFightWithZeroStaminaRechargesHero()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);

                hero.DrainStamina(40);
                hero.Fight(boss);

                var expectedHeroStaminaAfterRecharge = 40;

                Assert.AreEqual(hero.Stamina, expectedHeroStaminaAfterRecharge);
            }

            [Test]
            public void TestFightTakesZeroHealthFromEnemyWhenRecharging()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);

                hero.DrainStamina(40);
                var expectedHealthAfterFight = 400;

                hero.Fight(boss);

                Assert.AreEqual(boss.Health, expectedHealthAfterFight);
            }

            [Test]
            public void TestFightTakesEnemyHealthWithStrenghtInput()
            {
                GameCharacter boss = new GameCharacter(400, 20, 10);
                GameCharacter hero = new GameCharacter(100, 20, 40);
                var expectedHeroHealthAfterFight = 90;

                boss.Fight(hero, 10);

                Assert.AreEqual(hero.Health, expectedHeroHealthAfterFight);
            }

            //[Test]
            //public void TestItemInitialization()
            //{
            //    GamePlay gameplay = new GamePlay();

            //    int expectedListCountAfterInit = 10;

            //    Assert.AreEqual(expectedListCountAfterInit, gameplay.DroppableItems.Count);
            //}

            //[Test]
            //public void TestFindHealthPotion()
            //{
            //    GamePlay gameplay = new GamePlay();

            //    Item expectedItem = new Item("HealthPotion");

            //    Item actualItem = gameplay.GetHealthPotion();

            //    Assert.AreEqual(expectedItem, actualItem);
            //}

            //[Test]
            //public void TestDrinkPotionRestoresHealth()
            //{
            //    GameCharacter boss = new GameCharacter(400, 20, 10);
            //    GameCharacter hero = new GameCharacter(100, 20, 40);

            //    boss.Fight(hero, 90);
            //    Assert.AreEqual(10, hero.Health);

            //    hero.DrinkHealthPotion();

            //    Assert.AreEqual(hero.Health, 100);
            //}

            //[Test]
            //public void TestFindRandomItem()
            //{
            //    GamePlay gameplay = new GamePlay();

            //    Item droppedItem = gameplay.GetRandomItemToDrop();

            //    Assert.IsNotNull(droppedItem);
            //}

            //[Test]
            //public void TestDrinkStaminaPotionRestoresStamina()
            //{
            //    GameCharacter hero = new GameCharacter(100, 20, 40);

            //    hero.DrainStamina(40);
            //    hero.DrinkStaminaPotion();

            //    Assert.AreEqual(hero.Stamina, 40);
            //}


            //[Test]
            //public void TestDrinkStrengthPotionTakesAdditionalDamage()
            //{
            //    GameCharacter hero = new GameCharacter(100, 20, 40);
            //    GameCharacter boss = new GameCharacter(400, 20, 10);

            //    hero.DrinkStrengthPotion();

            //    Assert.AreEqual(boss.Health, 370);
            //}
      }


 }


