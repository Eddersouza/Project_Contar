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
        /// Store Account Payable App instance.
        /// </summary>
        private readonly AccountPayableAppContract _accountPayableApp;

        /// <summary>
        /// Try add new account with field Name empty.
        /// </summary>
        [Test]
        public void C1AddNewAccountPayableWithNameEmpty()
        {
            AccountPayableAppContract accountPayableApp = new AccountPayableApp();

            List<string> errors = new List<string>();

            bool added = this._accountPayableApp
                .Add(
                string.Empty,
                new DateTime(2019, 05, 01),
                120,
                ref errors);

            var expected = new
            {
                sucess = false,
                error = "O Campo Nome é obrigatório."
            };

            var result = new
            {
                sucess = added,
                error = errors.FirstOrDefault()
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new account with Name length less than three characters.
        /// </summary>
        [Test]
        public void C2AddNewAccountPayableWithNameLessThanThreeCharacter()
        {
            List<string> errors = new List<string>();

            bool added = this._accountPayableApp
                .Add(
                "Lu",
                new DateTime(2019, 05, 01),
                120,
                ref errors);

            var expected = new
            {
                sucess = false,
                error = "O Campo Nome deve ser maior ou igual a 3 caracteres."
            };

            var result = new
            {
                sucess = added,
                error = errors.FirstOrDefault()
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new account with Name greater less than twenty characters.
        /// </summary>
        [Test]
        public void C3AddNewAccountPayableWithNameGreaterThanTwentyCharacter()
        {
            List<string> errors = new List<string>();

            bool added = this._accountPayableApp
                .Add(
                "Teste para Adicionar mais de vinte caracter.",
                new DateTime(2019, 05, 01),
                120,
                ref errors);

            var expected = new
            {
                sucess = false,
                error = "O Campo Nome deve ser menor ou igual a vinte caracteres."
            };

            var result = new
            {
                sucess = added,
                error = errors.FirstOrDefault()
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new account with value equal to zero.
        [Test]
        public void C4AddNewAccountPayableWithValueEqualToZero()
        {
            List<string> errors = new List<string>();

            bool added = this._accountPayableApp
                .Add(
                "Luz",
                new DateTime(2019, 05, 01),
                0,
                ref errors);

            var expected = new
            {
                sucess = false,
                error = "O Campo Valor deve ser maior que 0."
            };

            var result = new
            {
                sucess = added,
                error = errors.FirstOrDefault()
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new acount with empty date.
        /// </summary>
        [Test]
        public void C5AddNewAccountPayableWithEmptyDate()
        {
            List<string> errors = new List<string>();

            bool added = this._accountPayableApp
                .Add(
                "Luz",
                null,
                0,
                ref errors);

            var expected = new
            {
                sucess = false,
                error = "O Campo Valor deve ser maior que 0."
            };

            var result = new
            {
                sucess = added,
                error = errors.FirstOrDefault()
            };

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Try add new acount with success.
        /// </summary>
        [Test]
        public void C7AddNewAccountPayableWithSuccess()
        {
            List<string> errors = new List<string>();

            bool added = this._accountPayableApp
                .Add(
                "Luz",
                new DateTime(2019, 05, 01),
                0,
                ref errors);

            var expected = new
            {
                sucess = true,
                error = "Conta Incluída com Sucesso."
            };

            var result = new
            {
                sucess = added,
                error = errors.FirstOrDefault()
            };

            Assert.AreEqual(expected, result);
        }
    }
}