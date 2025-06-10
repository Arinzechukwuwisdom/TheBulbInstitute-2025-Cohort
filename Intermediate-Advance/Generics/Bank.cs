namespace Generics
{
    public class Bank<T>
    {
        private List<Bank<T>> bankList = new List<Bank<T>>();
        // ResponseDetail<Bank<T>> response = new ResponseDetail<Bank<T>>();
        public T Id { get; set; }
        public T AccountNumber { get; set; }
        public double Balance { get; set; }

        public ResponseDetail<Bank<T>> CreateAccount(T id, T accountNumber, double initialBalance)
        {
            var response = new ResponseDetail<Bank<T>>();
            try
            {
                if (bankList.Any(b => b.Id.Equals(id)))
                {
                    response = response.Failed("Account with this ID already exists", 400);
                }
                if (initialBalance < 200)
                {
                    response = response.Failed("Initial balance must be at least 200", 400);
                }
                var newBank = new Bank<T>
                {
                    Id = id,
                    AccountNumber = accountNumber,
                    Balance = initialBalance
                };

                bankList.Add(newBank);
                response = response.Success(newBank, "Account created successfully", 201);

            }
            catch (Exception ex)
            {
                response = response.Failed(ex.Message, ex.HResult);

            }
            return response;
        }
    }
}
