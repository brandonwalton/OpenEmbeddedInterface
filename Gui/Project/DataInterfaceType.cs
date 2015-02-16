using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenEmbeddedInterface.Gui
{
    /// <summary>
    /// Represents the a type of serial protocol used for data exchange.
    /// </summary>
    public enum DataInterfaceType
    {
        /// <summary>
        /// The user has not decided which type to use.
        /// </summary>
        DecideLater = 0,
        /// <summary>
        /// Standard UART serial stream.
        /// </summary>
        UART,
        /// <summary>
        /// I2C (I squared C) serial stream.
        /// </summary>
        I2C,
        /// <summary>
        /// Serial peripheral interface serial stream.
        /// </summary>
        SPI,
        /// <summary>
        /// Controller area network serial stream.
        /// </summary>
        CAN,
        /// <summary>
        /// Ethernet serial stream.
        /// </summary>
        Ethernet,
        /// <summary>
        /// Bit banging serial stream.
        /// </summary>
        BitBanging
    }
}
