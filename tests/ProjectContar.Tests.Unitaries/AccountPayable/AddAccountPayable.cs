using NUnit.Framework;
using ProjectContar.App;
using ProjectContar.Domain.Contracts.App;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectContar.Tests.Unitaries.AccountPayable
{
    /// <summary>
    /// Represents the test to Add new Account Payable.
    /// </summary>
    [TestFixture]
    public class AddAccountPayable
    {
      
        /// <summary>
        /// Try add new account with field Name empty.
        /// </summary>
        [Test]
        public void C1AddNewAccountPayableWithNameEmpty()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            accountPayableApp
                .Add(
                string.Empty,
                new DateTime(2019, 05, 01),
                120);

            if (accountPayableApp.HasWarnings)
                foreach (var item in accountPayableApp.Warnings())
                {
                    errors.Add(item.ToString());
                }

            var expected = new
            {
                sucess = false,
                error = true
            };

            var result = new
            {
                sucess = !accountPayableApp.HasNotifications,
                error = errors.Contains("O Campo Nome é obrigatório.")
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new account with Name length less than three characters.
        /// </summary>
        [Test]
        public void C2AddNewAccountPayableWithNameLessThanThreeCharacter()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            accountPayableApp
               .Add(
               "Lu",
               new DateTime(2019, 05, 01),
               120);

            if (accountPayableApp.HasWarnings)
                foreach (var item in accountPayableApp.Warnings())
                {
                    errors.Add(item.ToString());
                }

            var expected = new
            {
                sucess = false,
                error = true
            };

            var result = new
            {
                sucess = false,
                error = errors.Contains("O Campo Nome deve ser maior ou igual a 3 caracteres.")
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new account with Name greater less than twenty characters.
        /// </summary>
        [Test]
        public void C3AddNewAccountPayableWithNameGreaterThanTwentyCharacter()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            accountPayableApp
                .Add(
                "Teste para Adicionar mais de vinte caracter.",
                new DateTime(2019, 05, 01),
                120);

            if (accountPayableApp.HasWarnings)
                foreach (var item in accountPayableApp.Warnings())
                {
                    errors.Add(item.ToString());
                }

            var expected = new
            {
                sucess = false,
                error = true
            };

            var result = new
            {
                sucess = false,
                error = errors.Contains("O Campo Nome deve ser menor ou igual a 20 caracteres.")
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new account with value equal to zero.
        [Test]
        public void C4AddNewAccountPayableWithValueEqualToZero()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            accountPayableApp
                .Add(
                "Luz",
                new DateTime(2019, 05, 01),
                0);

            if (accountPayableApp.HasWarnings)
                foreach (var item in accountPayableApp.Warnings())
                {
                    errors.Add(item.ToString());
                }

            var expected = new
            {
                sucess = false,
                error = true
            };

            var result = new
            {
                sucess = false,
                error = errors.Contains("O Campo Valor deve ser maior que 0.")
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new acount with empty date.
        /// </summary>
        [Test]
        public void C5AddNewAccountPayableWithEmptyDate()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            accountPayableApp
                .Add(
                "Luz",
                null,
                0);

            if (accountPayableApp.HasWarnings)
                foreach (var item in accountPayableApp.Warnings())
                {
                    errors.Add(item.ToString());

                }

            var expected = new
            {
                sucess = false,
                error = true
            };

            var result = new
            {
                sucess = false,
                error = errors.Contains("O Campo Data não pode ser vazio.")
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new acount with success.
        /// </summary>
        [Test]
        public void C7AddNewAccountPayableWithSuccess()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            accountPayableApp
               .Add(
               "Luz",
               new DateTime(2019, 05, 01),
               120);

            if (accountPayableApp.HasInformations)
                foreach (var item in accountPayableApp.Informations())
                {
                    errors.Add(item.ToString());

                }

            var expected = new
            {
                sucess = true,
                error = true
            };

            var result = new
            {
                sucess = true,
                error = errors.Contains("Conta Incluída com Sucesso.")
            };

            Assert.AreEqual(expected, result);
        }
    }
}