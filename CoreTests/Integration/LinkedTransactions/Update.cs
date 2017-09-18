using NUnit.Framework;

namespace CoreTests.Integration.LinkedTransactions
{
    public class Update : LinkedTransactionTest
    {
        [Test]
        public void can_assign_a_contact_to_an_existing_linked_transaction()
        {
            Given_a_basic_linked_transaction();
            Given_a_contact();
            LinkedTransaction.ContactID = ContactId;

            var linkedTransaction = Api.LinkedTransactions.Update(LinkedTransaction);

            Assert.True(linkedTransaction.Id == LinkedTransactionId);
            Then_the_contact_details_are_correct(linkedTransaction, ContactId);
        }

        [Test]
        public void can_allocate_an_existing_linked_transaction_to_a_target_transaction()
        {
            Given_a_linked_transaction_assigned_to_a_contact();

            Given_a_target_invoice(Contact);

            LinkedTransaction.TargetTransactionID = TargetId;
            LinkedTransaction.TargetLineItemID = TargetLineItemId;

            var linkedTransaction = Api.LinkedTransactions.Update(LinkedTransaction);

            Assert.True(linkedTransaction.Id == LinkedTransactionId);
            Then_the_contact_details_are_correct(linkedTransaction, ContactId);
            Then_the_target_details_are_correct(linkedTransaction, TargetId, TargetLineItemId);
        }
    }
}
