using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstract_Task.Models
{
    abstract class Block
    {
        public string Id { get; set; }

        public abstract void Which();

    }
}
