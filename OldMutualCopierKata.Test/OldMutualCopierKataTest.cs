using Moq;
using OldMutualCopierKata.Abstract;

namespace OldMutualCopierKata.Test
{
    public class OldMutualCopierKataTest
    {
        private readonly Copier copier;
        private readonly Mock<ISource> sourceerviceMock = new();
        private readonly Mock<IDestination> destinationServiceMock = new();

        public OldMutualCopierKataTest()
        {
            copier = new Copier(sourceerviceMock.Object, destinationServiceMock.Object);
        }
        [Fact]
        public void Copy_Stops_When_Newline()
        {
            var source = '\n'; 
               
            sourceerviceMock.Setup(mock => mock.ReadChar())
                        .Returns(source);

            copier.Copy();
            destinationServiceMock.Verify(mock => mock.WriteChar(source), Times.Never);

         }

       [ Fact]
        public void Copy_Read_Source_Write_Destination() 
        {
            var source = 's';

           
            sourceerviceMock.Setup(mock => mock.ReadChar())
                        .Returns(source);

            copier.Copy(); 
            
           
            Assert.Equal(sourceerviceMock.Invocations.Count, destinationServiceMock.Invocations.Count);
        }

        [Fact]
        public void Copy_Chars_Read_Source_Write_Destination()
        {
            var source = "asdfg".ToArray();
           
                sourceerviceMock.Setup(mock => mock.ReadChars(5))
                            .Returns(source);

                copier.CopyChars();
         

            Assert.Equal(sourceerviceMock.Invocations.Count, destinationServiceMock.Invocations.Count);
        }

        [Fact]
        public void Copy_Chars_Stops_When_Newline()
        {
            var source = "asdfg\n".ToArray();

            sourceerviceMock.Setup(mock => mock.ReadChars(5))
                        .Returns(source);

            copier.CopyChars();
            Assert.Equal(1, destinationServiceMock.Invocations.Count);
            //destinationServiceMock.Verify(mock => mock.WriteChars(source), Times.Once);

        }
    }
}