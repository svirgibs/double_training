﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Ivan");
            newData.MiddleName = "Ivanov";
            newData.LastName = "Ivanovich";

            app.Contacts.Modify(1, newData);
        }
    }
}
