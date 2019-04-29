using MessageBroker;
using MessageBroker.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using KassaAPI.Dto;

namespace RabbitMQ
{
    class MessageHandler : IMessageHandler
    {
        public void HandleAankoopMessage(AankoopMessage aankoopMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleBadgeMessage(BadgeMessage badgeMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleBezoekerMessage(BezoekerMessage bezoekerMessage)
        {
            DtoCustomer dtoCustomer = new DtoCustomer(
                bezoekerMessage.body.bezoekerUUID.ToString(),
                bezoekerMessage.body.kaartUUID.ToString(),
                bezoekerMessage.body.adres.ToString(),
                /*Voornaam en achternam*/"Anthony Moortgat",
                bezoekerMessage.body.email.ToString(),
                /*Barcode*/"ABC-abc-1234",
                bezoekerMessage.body.btwnummer.ToString(),
                bezoekerMessage.body.isActief,
                bezoekerMessage.body.isGeblokkeerd,
                bezoekerMessage.header.timestamp,
                bezoekerMessage.header.versie
                ); 

            // Call API function en stuur object door
            throw new NotImplementedException();
        }

        public void HandleCreditnotaMessage(CreditnotaMessage creditnotaMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleErrorMessage(ErrorMessage errorMessage)
        {
            // Enkel voor monitoring ?
        }

        public void HandleEventMessage(EventMessage eventMessage)
        {
            // todo
            // throw new NotImplementedException();
        }

        public void HandleFactuurMessage(FactuurMessage factuurMessage)
        {
            //throw new NotImplementedException();

            //niet doen
        }

        public void HandleGroepRegistratieMessage(GroepRegistratieMessage groepResgistratieMessage)
        {
            //throw new NotImplementedException();
        }

        public void HandleInschrijvingsMessage(InschrijvingsMessage inschrijvingsMessage)
        {
            throw new NotImplementedException();
            // todo
        }

        public void HandleKalenderMessage(KalenderMessage kalenderMessage)
        {
           
        }

        public void HandleKeepAliveMessage(KeepAliveMessage keepAliveMessage)
        {
            
        }

        public void HandleLocatieMessage(LocatieMessage locatiemessage)
        {
            
        }

        public void HandleOplaadMessage(OplaadMessage oplaadMessage)
        {
           
            throw new NotImplementedException();
            // todo
        }

        public void HandleOrganisatieMessage(OrganisatieMessage organisatieMessage)
        {
            // todo
            // throw new NotImplementedException();
        }

        public void HandlePingMessage(PingMessage pingMessage)
        {

        }

        public void HandleRegistratieMessage(RegistratieMessage registratieMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleReservatieMessage(ReservatieMessage reservatieMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleSessieMessage(SessieMessage sessieMessage)
        {
            // todo: Een sessie als product maken
            // throw new NotImplementedException();
        }

        public void HandleTaakMessage(TaakMessage taakMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleVerkoopsItemMessage(VerkoopsItemMessage verkoopsItemMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleWerkMessage(WerkMessage werkMessage)
        {
            throw new NotImplementedException();
        }

        public void HandleWerknemerMessage(WerknemerMessage werknemerMessage)
        {
            // Werknemer is een gewoone user maar met bool werknemer op true
            // todo: Dto van partner
            // throw new NotImplementedException();
        }
    }
}
