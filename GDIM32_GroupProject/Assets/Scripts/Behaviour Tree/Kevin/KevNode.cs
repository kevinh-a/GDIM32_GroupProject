using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public enum NodeState
    {
        RUNNING,
        SUCCESS,
        FAILURE
    }
    public class KevNode
    {
        protected NodeState state;

        public KevNode parent;
        protected List<KevNode> children = new List<KevNode>();

        private Dictionary<string, object> dataContext = new Dictionary<string, object>();

        public KevNode()
        {
            parent = null;
        }
        public KevNode(List<KevNode> children)
        {
            foreach(KevNode child in children)
                Attach(child);
        }

        private void Attach(KevNode node)
        {
            node.parent = this;
            children.Add(node);
        }

        public virtual NodeState Evaluate() => NodeState.FAILURE;

        public void SetDate(string key, object value)
        {
            dataContext[key] = value;
        }

        public object GetData(string key)
        {
            object value = null;
            if (dataContext.TryGetValue(key, out value))
                return value;

            KevNode node = parent;
            while (node != null)
            {
                value = node.GetData(key);
                if(value != null)
                {
                    return value;
                }
                node = node.parent;
            }
            return null;
        }

        public bool ClearData(string key)
        {
            if (dataContext.ContainsKey(key))
            {
                dataContext.Remove(key);
                return true;
            }

            KevNode node = parent;
            while (node!= null)
            {
                bool cleared = node.ClearData(key);
                if (cleared)
                {
                    return true;
                }
                node = node.parent;
            }
            return false;
        }
    }
}
