using System;
using System.Collections.Generic;

namespace Swinadventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>(idents);
        }

        public bool AreYou(string id)
        {
            bool testAreYou = false;
            for (int i = 0; i < _identifiers.Count; i++)
            {
                if (_identifiers[i].ToLower().Equals(id.ToLower()))
                {
                    testAreYou = true;
                }
            }
            return testAreYou;
        }

        public string FirstID()
        {
            string first = _identifiers.Count > 0 ? _identifiers[0] : "";
            return first ?? "";
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
